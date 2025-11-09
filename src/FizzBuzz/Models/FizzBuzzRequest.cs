namespace FizzBuzz.Models;

/// <summary>
/// Request model for FizzBuzz execution with configurable rules.
/// </summary>
public class FizzBuzzRequest
{
    /// <summary>
    /// Starting number (inclusive). Default is 1.
    /// </summary>
    public int Start { get; set; } = 1;

    /// <summary>
    /// Ending number (inclusive). Default is 100.
    /// </summary>
    public int End { get; set; } = 100;

    /// <summary>
    /// Include Fuzz rule (divisible by 4). Default is false.
    /// </summary>
    public bool IncludeFuzz { get; set; } = false;

    /// <summary>
    /// Include Jazz rule (divisible by 9). Default is false.
    /// </summary>
    public bool IncludeJazz { get; set; } = false;

    /// <summary>
    /// Reverse the output order (count from End to Start). Default is false.
    /// </summary>
    public bool Reverse { get; set; } = false;
}
