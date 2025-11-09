using FizzBuzz.Models;

namespace FizzBuzz.Interfaces;

/// <summary>
/// Service interface for FizzBuzz operations.
/// </summary>
public interface IFizzBuzzService
{
    /// <summary>
    /// Generates FizzBuzz results based on the provided request.
    /// </summary>
    /// <param name="request">Configuration for FizzBuzz execution</param>
    /// <returns>FizzBuzz results</returns>
    FizzBuzzResponse Generate(FizzBuzzRequest request);
}
