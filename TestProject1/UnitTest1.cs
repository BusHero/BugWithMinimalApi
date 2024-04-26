using FluentAssertions;
using Flurl.Http;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var result = await "http://localhost:5172"
            .AllowAnyHttpStatus()
            .PostAsync();

        result.StatusCode
            .Should()
            .Be(400);
    }
}