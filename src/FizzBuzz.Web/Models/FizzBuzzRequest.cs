namespace FizzBuzz.Web.Models;

/// <summary>
/// Request model for FizzBuzz execution with configurable rules.
/// </summary>
public class FizzBuzzRequest
{
    public int Start { get; set; } = 1;

    public int End { get; set; } = 100;

    public bool IncludeFuzz { get; set; } = false;

    public bool IncludeJazz { get; set; } = false;

    public bool Reverse { get; set; } = false;
}
