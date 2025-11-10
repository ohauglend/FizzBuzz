namespace FizzBuzz.Web.Models;

/// <summary>
/// Response model containing FizzBuzz execution results.
/// </summary>
public class FizzBuzzResponse
{
    public string[] Results { get; set; } = Array.Empty<string>();

    public int Count => Results.Length;
}
