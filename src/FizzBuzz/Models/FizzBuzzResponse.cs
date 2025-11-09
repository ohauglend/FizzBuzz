namespace FizzBuzz.Models;

/// <summary>
/// Response model containing FizzBuzz execution results.
/// </summary>
public class FizzBuzzResponse
{
    /// <summary>
    /// Array of FizzBuzz results.
    /// </summary>
    public string[] Results { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Total count of results.
    /// </summary>
    public int Count => Results.Length;
}
