using Xunit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

using Newtonsoft.Json;
using System.Collections.Generic;
using WebApis.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

public class TodoItemsControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public TodoItemsControllerTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        });
    }

    [Fact]
    public async Task GetAll_ReturnsEmptyList_WhenNoItemsAdded()
    {
        // Arrange
        var response = await _client.GetAsync("/weatherforecast");

        response.EnsureSuccessStatusCode();
        var stringResponse = await response.Content.ReadAsStringAsync();
        var todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(stringResponse);

        // Ensure todoItems is not null before calling Assert.Empty
        Assert.NotNull(todoItems); // This line checks that todoItems is not null.
        Assert.Empty(todoItems); // Now, we're sure that todoItems is not null when we assert it's empty.
    }
}
/* 
*   WebApis.Tests/Controllers/TodoItemsControllerTests.cs
 */