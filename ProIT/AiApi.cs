using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class AiApi
{
    private readonly HttpClient _client;
    private readonly string _apiKey;

    public int ChatId { get; set; }
    public int UserId { get; set; }

    public AiApi(string baseUrl, string apiKey, int chatId, int userId)
    {
        _client = new HttpClient { BaseAddress = new Uri(baseUrl) };
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _apiKey = apiKey;
        ChatId = chatId;
        UserId = userId;
    }

    public async Task<string> SendMessageAsync(string messageText)
    {
        string chatHistory = "";
        var data = new
        {
            chat_id = ChatId,
            user_id = UserId,
            message_text = messageText,
            chat_history = chatHistory,
            api_key = _apiKey
        };

        var jsonString = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
        HttpResponseMessage response = await _client.PostAsync("api/process_message", content);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}