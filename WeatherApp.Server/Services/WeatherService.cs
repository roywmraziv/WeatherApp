using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WeatherApp.Server.Models;

namespace WeatherApp.Server.Controllers;


public class WeatherService
{
    private readonly HttpClient _client;
    private readonly string _apiKey;

    public WeatherService(HttpClient client, string apiKey)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
        _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        _client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
    }

    public async Task<WeatherData> GetWeatherAsync(string city)
    {
        string url = $"weather?q={city}&appid={_apiKey}";

        try
        {
            string response = await _client.GetStringAsync(url);
            return JsonSerializer.Deserialize<WeatherData>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        catch(HttpRequestException ex)
        {
            throw new Exception($"Failed to fetch weather for {city}: {ex.Message}");
        }
    }

}
