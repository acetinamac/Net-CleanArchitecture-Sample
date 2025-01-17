﻿using CleanArchitecture.Sample.Web;
using Xunit;

namespace CleanArchitecture.Sample.FunctionalTests.ControllerApis;
[Collection("Sequential")]
public class MetaControllerInfo : IClassFixture<CustomWebApplicationFactory<Program>>
{
  private readonly HttpClient _client;

  public MetaControllerInfo(CustomWebApplicationFactory<Program> factory)
  {
    _client = factory.CreateClient();
  }

  [Fact]
  public async Task ReturnsVersionAndLastUpdateDate()
  {
    var response = await _client.GetAsync("/info");
    response.EnsureSuccessStatusCode();
    var stringResponse = await response.Content.ReadAsStringAsync();

    Assert.Contains("Version", stringResponse);
    Assert.Contains("Last Updated", stringResponse);
  }
}
