
using Newtonsoft.Json;
using WebApis.Models;
using System.Net.Http;
using System.Diagnostics;

namespace WebApis.Tests;

public class WeatherforecastTests
{
    private HttpClient _client = new();

    public WeatherforecastTests()
    {
    }

    public HttpClient Client { get => _client; set => _client = value; }

    [Fact]
    public async Task WeatherforecastAsync()
    {
        // Check  if the closest date in the given list in http://localhost:5186/weatherforecast is today
        var response = await _client.GetAsync("/weatherforecast");

        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        var forecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(stringResponse);
        // print the closest date in the forecasts list
        Debug.WriteLine(forecasts?.OrderBy(f => Math.Abs((f.Date - DateTime.Today).TotalDays)).First().Date);
        // Check if the closest date in the forecasts list is today
        var closestForecast = forecasts?.OrderBy(f => Math.Abs((f.Date - DateTime.Today).TotalDays)).First();

        bool isClosestDateToday = true;
        isClosestDateToday = (closestForecast?.Date == DateTime.Today);
        Assert.True(condition: isClosestDateToday | false, userMessage: "The closest date in the forecasts list is not today.");

    }
}