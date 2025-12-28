using DR_APIs.Models;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DR_APIs.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordStatus { Unassigned, Valid, PossibleMatch, New, Updated };

    public class Diver
    {
        public int ID { get; set; }
        public int? ArchiveID { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // Club full name (e.g. "Aurajoen Uinti", "Manchester Aquatics Centre")
        public string? Representing { get; set; }

        // Gender parsed from the CSV column (M/F or missing)
        public string? Sex { get; set; }

        // Year of birth 
        public int? Born { get; set; }

        // Coach name, often empty
        public string? Coach { get; set; }

        // Short club code when present (e.g. AUI, MAC, SSA)
        public string? TCode { get; set; }

        // Country name or country code (varies in the CSV)
        public string? Nation { get; set; }

        // Convenience property
        public string FullName => string.Join(' ', new[] { FirstName, LastName }.Where(s => !string.IsNullOrWhiteSpace(s)));

        public RecordStatus RecordStatus { get; set; }

        public List<Diver> PossibleMatches { get; set; }

        /// <summary>
        /// Parse a CSV file (with header) into a list of <see cref="Diver"/>.
        /// Expected header names (case-insensitive): "DRef","Name","FirstName","Representing","Sex","Born",
        /// "CoachName","TeamCode","Registration","AsciiName","AsciiFirst","Representing2","TeamCode2","DiverGUID"
        /// Extra columns are ignored.
        /// </summary>
        public static List<Diver> ParseDivers(string filePath)
        {
            if (filePath is null) throw new ArgumentNullException(nameof(filePath));
            if (!File.Exists(filePath)) throw new FileNotFoundException("CSV file not found", filePath);

            var divers = new List<Diver>();

            using (var parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;

                if (parser.EndOfData) return divers;

                var headerFields = Headers.DiverHeader.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var index = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                for (int i = 0; i < headerFields.Length; i++)
                {
                    var h = headerFields[i]?.Trim().Trim('"');
                    if (!string.IsNullOrEmpty(h) && !index.ContainsKey(h))
                        index[h] = i;
                }

                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields() ?? Array.Empty<string>();
                    if (fields.Length == 0) continue;

                    string GetField(string name)
                    {
                        if (!index.TryGetValue(name, out var pos)) return string.Empty;
                        if (pos < 0 || pos >= fields.Length) return string.Empty;
                        return fields[pos] ?? string.Empty;
                    }

                    var d = new Diver();

                    d.ID = ParseInt(GetField("DRef"));
                    d.LastName = NullIfEmpty(GetField("Name"));
                    d.FirstName = NullIfEmpty(GetField("FirstName"));
                    d.Representing = NullIfEmpty(GetField("Representing"));
                    d.Sex = NullIfEmpty(GetField("Sex"));

                    // Born: treat empty or 0 as null
                    d.Born = ParseNullableInt(GetField("Born"), treatZeroAsNull: true);

                    d.Coach = NullIfEmpty(GetField("CoachName"));
                    d.TCode = NullIfEmpty(GetField("TeamCode"));
                    d.Nation = NullIfEmpty(GetField("Registration"));

                    // Ensure lists are initialized to avoid null references elsewhere
                    d.PossibleMatches = new List<Diver>();

                    divers.Add(d);
                }
            }

            return divers;
        }

        private static string? NullIfEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim().Trim('"');

        private static int ParseInt(string raw, int defaultValue = 0)
        {
            raw = raw?.Trim().Trim('"') ?? string.Empty;
            if (int.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var v)) return v;
            return defaultValue;
        }

        private static int? ParseNullableInt(string raw, bool treatZeroAsNull = false)
        {
            raw = raw?.Trim().Trim('"') ?? string.Empty;
            if (string.IsNullOrEmpty(raw)) return null;
            if (int.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var v))
            {
                if (treatZeroAsNull && v == 0) return null;
                return v;
            }
            return null;
        }

        public static List<Diver> MissingDivers(List<Diver> listA, List<Diver> listB)
        {
            if (listA is null) throw new ArgumentNullException(nameof(listA));
            if (listB is null || listB.Count == 0) return new List<Diver>(listA);

            var bIds = new HashSet<int>();
            foreach (var d in listB)
            {
                if (d is null) continue;
                bIds.Add(d.ID);
            }

            var result = new List<Diver>(listA.Count);
            foreach (var d in listA)
            {
                if (d is null) continue;
                if (!bIds.Contains(d.ID))
                    result.Add(d);
            }

            return result;
        }

        public static async Task<List<Diver>> CheckDiversAsync(List<Diver> divers, CancellationToken cancellationToken = default)
        {
            if (divers is null) throw new ArgumentNullException(nameof(divers));

            var baseUrl = Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/Divers/CheckDivers";

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var json = JsonSerializer.Serialize(divers, jsonOptions);

            using var handler = new HttpClientHandler();
            // Accept self-signed certs in dev (only for local/dev use)
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true;

            using var client = new HttpClient(handler);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var response = await client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
                return new List<Diver>();

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (string.IsNullOrWhiteSpace(responseJson))
                return new List<Diver>();

            var result = JsonSerializer.Deserialize<List<Diver>>(responseJson, jsonOptions);

            return result ?? new List<Diver>();
        }

        public static async Task<List<Diver>> UpdateDiversAsync(List<Diver> divers, User user, CancellationToken cancellationToken = default)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true;

            if (divers is null) throw new ArgumentNullException(nameof(divers));

            // Base URL can be overridden by setting environment variable API_BASE_URL, otherwise fallback to localhost.
            var baseUrl = Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/Divers/UpdateDivers";

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var json = JsonSerializer.Serialize(divers, jsonOptions);

            using var client = new HttpClient(httpClientHandler);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Add("X-API-KEY", user.APIKey);
            client.DefaultRequestHeaders.Add("X-API-ID", user.UserEmail.ToString());

            using var response = await client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(false);

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException(responseJson.ToString());
            }

            if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new Exception(responseJson.ToString());
            }

            var result = JsonSerializer.Deserialize<List<Diver>>(responseJson, jsonOptions);
            return result ?? new List<Diver>();
        }

        /// <summary>
        /// Call the REST service /Divers/MergeDivers to merge two diver records.
        /// The first diver (survivor) will be kept, and the second diver (casualty) will be deleted.
        /// All dive sheet references to the casualty will be updated to point to the survivor.
        /// Returns true on success, throws exceptions on errors.
        /// </summary>
        /// <param name="survivor">The diver record to keep (must have ArchiveID)</param>
        /// <param name="casualty">The diver record to delete (must have ArchiveID)</param>
        /// <param name="user">User with authentication credentials</param>
        /// <param name="cancellationToken">Optional cancellation token</param>
        /// <returns>True if merge was successful</returns>
        /// <exception cref="ArgumentNullException">Thrown when survivor, casualty, or user is null</exception>
        /// <exception cref="ArgumentException">Thrown when survivor or casualty don't have ArchiveID</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when user lacks permissions</exception>
        /// <exception cref="HttpRequestException">Thrown for other HTTP errors</exception>
        public static async Task<bool> MergeDiversAsync(Diver survivor, Diver casualty, User user, CancellationToken cancellationToken = default)
        {
            if (survivor is null) throw new ArgumentNullException(nameof(survivor));
            if (casualty is null) throw new ArgumentNullException(nameof(casualty));
            if (user is null) throw new ArgumentNullException(nameof(user));

            if (!survivor.ArchiveID.HasValue)
                throw new ArgumentException("Survivor diver must have an ArchiveID", nameof(survivor));
            if (!casualty.ArchiveID.HasValue)
                throw new ArgumentException("Casualty diver must have an ArchiveID", nameof(casualty));

            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => true;

            var baseUrl = Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/Divers/MergeDivers";

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Create a list with exactly 2 divers as expected by the controller
            var diversToMerge = new List<Diver> { survivor, casualty };
            var json = JsonSerializer.Serialize(diversToMerge, jsonOptions);

            using var client = new HttpClient(httpClientHandler);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Add("X-API-KEY", user.APIKey);
            client.DefaultRequestHeaders.Add("X-API-ID", user.UserEmail.ToString());

            using var response = await client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(false);

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException(responseJson);
            }

            if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new HttpRequestException($"Server error during merge: {responseJson}");
            }

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"HTTP {response.StatusCode}: {responseJson}");
            }

            // Try to deserialize the boolean result
            try
            {
                var result = JsonSerializer.Deserialize<bool>(responseJson, jsonOptions);
                return result;
            }
            catch
            {
                // Fallback: check if response contains "true" (case-insensitive)
                return responseJson.Trim().Trim('"').Equals("true", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
