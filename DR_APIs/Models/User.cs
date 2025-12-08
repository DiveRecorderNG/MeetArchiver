using System.Text.Json;

namespace DR_APIs.Models
{
    public class User
    {
        public string APIKey { get; set; }
        public string UserEmail { get; set; }
        public string Role { get; set; }
        public int pk { get; set; }




        public static async Task<User> GetUserAsync(string APIKey, string email, System.Threading.CancellationToken cancellationToken = default)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            // Base URL can be overridden by setting environment variable API_BASE_URL, otherwise fallback to localhost.
            var baseUrl = System.Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/User/GetUser?APIKey=" + APIKey + "&email=" + email;

            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var json = System.Text.Json.JsonSerializer.Serialize(APIKey, jsonOptions);

            using var client = new System.Net.Http.HttpClient(httpClientHandler);
            using var content = new System.Net.Http.StringContent(json, System.Text.Encoding.UTF8, "application/json");

            using var response = await client.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
            //response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (string.IsNullOrWhiteSpace(responseJson)) return new User();

            var result = System.Text.Json.JsonSerializer.Deserialize<User>(responseJson, jsonOptions);
            return result ?? new User();
        }

        public static async Task<bool> CreateUserAsync(string APIKey, string email, User user, System.Threading.CancellationToken cancellationToken = default)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            // Base URL can be overridden by setting environment variable API_BASE_URL, otherwise fallback to localhost.
            var baseUrl = System.Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/User/CreateUser?APIKey=" + APIKey + "&email=" + email;

            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var json = System.Text.Json.JsonSerializer.Serialize(APIKey, jsonOptions);

            using var client = new System.Net.Http.HttpClient(httpClientHandler);
            using var content = new System.Net.Http.StringContent(json, System.Text.Encoding.UTF8, "application/json");


            client.DefaultRequestHeaders.Add("X-API-KEY", user.APIKey);
            client.DefaultRequestHeaders.Add("X-API-ID", user.UserEmail.ToString());

            using var response = await client.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
            //response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (string.IsNullOrWhiteSpace(responseJson)) return false;

            var result = System.Text.Json.JsonSerializer.Deserialize<bool>(responseJson, jsonOptions);
            return result ;
        }

        public static async Task<bool> UpdateUserAsync(string APIKey, string email, User user, System.Threading.CancellationToken cancellationToken = default)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            // Base URL can be overridden by setting environment variable API_BASE_URL, otherwise fallback to localhost.
            var baseUrl = System.Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/User/UpdateUser?APIKey=" + APIKey + "&email=" + email;

            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var json = System.Text.Json.JsonSerializer.Serialize(APIKey, jsonOptions);

            using var client = new System.Net.Http.HttpClient(httpClientHandler);
            using var content = new System.Net.Http.StringContent(json, System.Text.Encoding.UTF8, "application/json");


            client.DefaultRequestHeaders.Add("X-API-KEY", user.APIKey);
            client.DefaultRequestHeaders.Add("X-API-ID", user.UserEmail.ToString());

            using var response = await client.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);
            //response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (string.IsNullOrWhiteSpace(responseJson)) return false;

            var result = System.Text.Json.JsonSerializer.Deserialize<bool>(responseJson, jsonOptions);
            return result;
        }

        public static async Task<bool> UserExistsAsync(string email, User user, System.Threading.CancellationToken cancellationToken = default)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            // Base URL can be overridden by setting environment variable API_BASE_URL, otherwise fallback to localhost.
            var baseUrl = System.Environment.GetEnvironmentVariable("API_BASE_URL") ?? "https://localhost:7034";
            var requestUri = $"{baseUrl.TrimEnd('/')}/User/UserExists?email=" + email;

            var jsonOptions = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            using var client = new System.Net.Http.HttpClient(httpClientHandler);

            client.DefaultRequestHeaders.Add("X-API-KEY", user.APIKey);
            client.DefaultRequestHeaders.Add("X-API-ID", user.UserEmail.ToString());

            using var response = await client.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
                throw new Exception("Service not found");

            if (string.IsNullOrWhiteSpace(responseJson)) return false;

            var result = System.Text.Json.JsonSerializer.Deserialize<bool>(responseJson, jsonOptions);
            return result;
        }

    }
}
