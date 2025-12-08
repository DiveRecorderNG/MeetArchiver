using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DR_APIs.Models
{
    public class DiveSheet
    {
        public int Meet { get; set; }
        public int Event { get; set; }
        public int DiverA { get; set; }
        public int DiverB { get; set; }

        public int Round { get; set; }
        public int Attempt { get; set; }
        public int StartOrder { get; set; }

        public int? DiveNo { get; set; }
        public string? Position { get; set; }
        public int? Board { get; set; }

        public decimal? Tariff { get; set; }

        public decimal? J1 { get; set; }
        public decimal? J2 { get; set; }
        public decimal? J3 { get; set; }
        public decimal? J4 { get; set; }
        public decimal? J5 { get; set; }
        public decimal? J6 { get; set; }
        public decimal? J7 { get; set; }
        public decimal? J8 { get; set; }
        public decimal? J9 { get; set; }
        public decimal? J10 { get; set; }
        public decimal? J11 { get; set; }

        public decimal? JTot { get; set; }
        public decimal? Points { get; set; }
        public decimal? CumPoints { get; set; }

        public bool? Cat1 { get; set; }
        public bool? Cat2 { get; set; }
        public bool? Cat3 { get; set; }
        public bool? Cat4 { get; set; }
        public bool? Cat5 { get; set; }
        public bool? Cat6 { get; set; }

        public decimal? PrevTot { get; set; }
        public bool? Retired { get; set; }
        public decimal? Predict { get; set; }
        public bool? Guest { get; set; }

        public string? Place { get; set; }
        public int? EPRef { get; set; }
        public decimal? Penalty { get; set; }
        public int? PlaceOrder { get; set; }

        public string? PSFPlace { get; set; }

        public string? P1 { get; set; }
        public string? P2 { get; set; }
        public string? P3 { get; set; }
        public string? P4 { get; set; }
        public string? P5 { get; set; }
        public string? P6 { get; set; }

        /// <summary>
        /// Parse a CSV file (with header) into a list of <see cref="DiveSheet"/>.
        /// Header names expected (case-insensitive): "Meet","Event","DiverA","DiverB","Round","Attempt",
        /// "StartOrder","DiveNo","Position","Board","Tariff","J1".."J11","JTot","Points","CumPoints",
        /// "Cat1".."Cat6","PrevTot","Retired","Predict","Guest","Place","EPRef","Penalty","PlaceOrder",
        /// "PSFPlace","P1".."P6"
        /// Extra columns are ignored.
        /// </summary>
        public static List<DiveSheet> ParseDiveSheets(string filePath)
        {
            if (filePath is null) throw new ArgumentNullException(nameof(filePath));
            if (!File.Exists(filePath)) throw new FileNotFoundException("CSV file not found", filePath);

            var list = new List<DiveSheet>();

            using var parser = new TextFieldParser(filePath)
            {
                TextFieldType = FieldType.Delimited
            };
            parser.SetDelimiters(",");
            parser.HasFieldsEnclosedInQuotes = true;

            if (parser.EndOfData) return list;

            var headerFields = Headers.DiveSheetHeader.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            var index = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < headerFields.Length; i++)
            {
                var h = headerFields[i]?.Trim().Trim('"');
                if (!string.IsNullOrEmpty(h) && !index.ContainsKey(h)) index[h] = i;
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

                var d = new DiveSheet
                {
                    Meet = ParseInt(GetField("Meet")),
                    Event = ParseInt(GetField("Event")),
                    DiverA = ParseInt(GetField("DiverA")),
                    DiverB = ParseInt(GetField("DiverB")),

                    Round = ParseInt(GetField("Round")),
                    Attempt = ParseInt(GetField("Attempt")),
                    StartOrder = ParseInt(GetField("StartOrder")),

                    DiveNo = ParseInt(GetField("DiveNo")),
                    Position = NullIfEmpty(GetField("Position")),
                    Board = ParseNullableInt(GetField("Board")),

                    Tariff = ParseNullableDecimal(GetField("Tariff")),

                    J1 = ParseNullableDecimal(GetField("J1")),
                    J2 = ParseNullableDecimal(GetField("J2")),
                    J3 = ParseNullableDecimal(GetField("J3")),
                    J4 = ParseNullableDecimal(GetField("J4")),
                    J5 = ParseNullableDecimal(GetField("J5")),
                    J6 = ParseNullableDecimal(GetField("J6")),
                    J7 = ParseNullableDecimal(GetField("J7")),
                    J8 = ParseNullableDecimal(GetField("J8")),
                    J9 = ParseNullableDecimal(GetField("J9")),
                    J10 = ParseNullableDecimal(GetField("J10")),
                    J11 = ParseNullableDecimal(GetField("J11")),

                    JTot = ParseNullableDecimal(GetField("JTot")),
                    Points = ParseNullableDecimal(GetField("Points")),
                    CumPoints = ParseNullableDecimal(GetField("CumPoints")),

                    Cat1 = ParseNullableBool(GetField("Cat1")),
                    Cat2 = ParseNullableBool(GetField("Cat2")),
                    Cat3 = ParseNullableBool(GetField("Cat3")),
                    Cat4 = ParseNullableBool(GetField("Cat4")),
                    Cat5 = ParseNullableBool(GetField("Cat5")),
                    Cat6 = ParseNullableBool(GetField("Cat6")),

                    PrevTot = ParseNullableDecimal(GetField("PrevTot")),
                    Retired = ParseNullableBool(GetField("Retired")),
                    Predict = ParseNullableDecimal(GetField("Predict")),
                    Guest = ParseNullableBool(GetField("Guest")),

                    Place = NullIfEmpty(GetField("Place")),
                    EPRef = ParseNullableInt(GetField("EPRef")),
                    Penalty = ParseNullableDecimal(GetField("Penalty")),
                    PlaceOrder = ParseNullableInt(GetField("PlaceOrder")),

                    PSFPlace = NullIfEmpty(GetField("PSFPlace")),

                    P1 = NullIfEmpty(GetField("P1")),
                    P2 = NullIfEmpty(GetField("P2")),
                    P3 = NullIfEmpty(GetField("P3")),
                    P4 = NullIfEmpty(GetField("P4")),
                    P5 = NullIfEmpty(GetField("P5")),
                    P6 = NullIfEmpty(GetField("P6"))
                };

                list.Add(d);
            }

            return list;
        }

        private static string? NullIfEmpty(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim().Trim('"');

        private static int ParseInt(string raw)
        {
            raw = raw?.Trim().Trim('"') ?? string.Empty;
            if (int.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var v)) return v;
            return 0;
        }

        private static int? ParseNullableInt(string raw)
        {
            raw = raw?.Trim().Trim('"') ?? string.Empty;
            if (string.IsNullOrEmpty(raw)) return null;
            if (int.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var v)) return v;
            return null;
        }

        private static decimal? ParseNullableDecimal(string raw)
        {
            raw = raw?.Trim().Trim('"') ?? string.Empty;
            if (string.IsNullOrEmpty(raw)) return null;
            if (decimal.TryParse(raw, NumberStyles.Number, CultureInfo.InvariantCulture, out var v)) return v;
            return null;
        }

        private static bool? ParseNullableBool(string raw)
        {
            raw = raw?.Trim().Trim('"') ?? string.Empty;
            if (string.IsNullOrEmpty(raw)) return null;
            if (bool.TryParse(raw, out var b)) return b;
            if (raw == "0") return false;
            if (raw == "1") return true;
            if (string.Equals(raw, "true", StringComparison.OrdinalIgnoreCase)) return true;
            if (string.Equals(raw, "false", StringComparison.OrdinalIgnoreCase)) return false;
            return null;
        }

        /// <summary>
        /// Call the API endpoint /DiveSheet/AddDiveSheet to insert a single divesheet row.
        /// Returns the last-inserted id on success, or -1 on error/empty response.
        /// </summary>
        public static async Task<int> AddDiveSheetsAsync(List<DiveSheet> ds, User user, CancellationToken cancellationToken = default)
        {
            if (ds is null) throw new ArgumentNullException(nameof(ds));

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;

            var baseUrl = Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/DiveSheet/AddDiveSheets";

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var json = JsonSerializer.Serialize(ds, jsonOptions);

            using var client = new HttpClient(handler);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Add("X-API-KEY", user.APIKey);
            client.DefaultRequestHeaders.Add("X-API-ID", user.UserEmail.ToString());

            using var response = await client.PostAsync(requestUri, content, cancellationToken).ConfigureAwait(false);

            var responseJson = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException(responseJson.ToString());
            }

            if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new Exception(responseJson.ToString());
            }

            return 1;
        }


    }
}
