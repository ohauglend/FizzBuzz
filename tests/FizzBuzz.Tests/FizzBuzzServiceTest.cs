using FizzBuzz.Services;
using FizzBuzz.Models;

namespace FizzBuzz.Tests;

public class FizzBuzzServiceTests
{
    private readonly FizzBuzzService _service = new();

    [Fact]
    public void Generate_3_Fizz()
    {
        // Arrange
        var request = new FizzBuzzRequest { Start = 3, End = 3 };
        
        // Act
        var response = _service.Generate(request);
        
        // Assert
        Assert.Single(response.Results);
        Assert.Equal("Fizz", response.Results[0]);
    }

    [Fact]
    public void Generate_5_Buzz()
    {
        // Arrange
        var request = new FizzBuzzRequest { Start = 5, End = 5 };
        
        // Act
        var response = _service.Generate(request);
        
        // Assert
        Assert.Single(response.Results);
        Assert.Equal("Buzz", response.Results[0]);
    }

    [Fact]
    public void Generate_4_Fuzz()
    {
        // Arrange
        var request = new FizzBuzzRequest { Start = 4, End = 4, IncludeFuzz = true };
        
        // Act
        var response = _service.Generate(request);
        
        // Assert
        Assert.Single(response.Results);
        Assert.Equal("Fuzz", response.Results[0]);
    }

    [Fact]
    public void Generate_9_Jazz()
    {
        // Arrange
        var request = new FizzBuzzRequest { Start = 9, End = 9, IncludeJazz = true };
        
        // Act
        var response = _service.Generate(request);
        
        // Assert
        Assert.Single(response.Results);
        Assert.Equal("FizzJazz", response.Results[0]);
    }

    [Fact]
    public void Generate_HappyPath_OneToOneHundred()
    {
        // Arrange
        var request = new FizzBuzzRequest { Start = 1, End = 100 };
        
        // Act
        var response = _service.Generate(request);
        
        // Assert
        Assert.Equal(100, response.Results.Length);
        Assert.Equal("1", response.Results[0]);
        Assert.Equal("Fizz", response.Results[2]);  // 3
        Assert.Equal("Buzz", response.Results[4]);  // 5
        Assert.Equal("FizzBuzz", response.Results[14]); // 15
        Assert.Equal("Buzz", response.Results[99]); // 100
    }

    [Fact]
    public void Generate_HappyPathReversed_OneToOneHundredReversed()
    {
        // Arrange
        var request = new FizzBuzzRequest { Start = 1, End = 100, Reverse = true };
        
        // Act
        var response = _service.Generate(request);
        
        // Assert
        Assert.Equal(100, response.Results.Length);
        Assert.Equal("Buzz", response.Results[0]); // 100 (reversed, so first)
        Assert.Equal("FizzBuzz", response.Results[85]); // 15 (100-15+1 = 86, 0-indexed = 85)
        Assert.Equal("Buzz", response.Results[95]); // 5
        Assert.Equal("Fizz", response.Results[97]); // 3
        Assert.Equal("1", response.Results[99]); // 1 (reversed, so last)
    }
}
