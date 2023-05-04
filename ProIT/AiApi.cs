using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProIT
{
    public class AiApi
    {
        public static HttpClient _httpClient;
        public static readonly string _apiBaseUrl = "https://89.22.107.179:8000/api/process_message";
        public static string _token;

        public AiApi(string token)
        {
            _httpClient = new HttpClient();
            _token = token;

            // Only use this line for testing purposes with self-signed certificates.
            // Remove this line in a production environment.
            _httpClient.DefaultRequestHeaders.Add("Connection", "close");
        }

        public async Task<string> SendMessage(string message)
        {
            var data = new
            {
                chat_id = 1,
                user_id = 2,
                message_text = message,
                chat_history = "",
                api_key = _token
            };

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_apiBaseUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var responseMessage = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                return responseMessage.response;
            }
            else
            {
                throw new Exception($"Error sending message: {response.StatusCode}");
            }
        }
    }
}