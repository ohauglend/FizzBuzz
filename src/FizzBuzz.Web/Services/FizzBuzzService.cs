using FizzBuzz.Web.Interfaces;
using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Services;

public class FizzBuzzService : IFizzBuzzService
{
    private const string Fizz = "Fizz";
    private const string Fuzz = "Fuzz";
    private const string Buzz = "Buzz";
    private const string Jazz = "Jazz";

    /// <summary>
    /// Generates FizzBuzz results based on the provided request.
    /// Rules apply additively:
    /// - Divisible by 3 → Fizz (always)
    /// - Divisible by 4 → Fuzz (optional)
    /// - Divisible by 5 → Buzz (always)
    /// - Divisible by 9 → Jazz (optional)
    public FizzBuzzResponse Generate(FizzBuzzRequest request)
    {
        if (request.Start > request.End)
        {
            throw new ArgumentException("Start must be less than or equal to End.", nameof(request));
        }

        //Set exact size of array
        var count = request.End - request.Start + 1;
        var results = new string[count];
        var index = 0;

        for (int i = request.Start; i <= request.End; i++)
        {
            results[index++] = ConvertNumberToFizzBuzz(i, request.IncludeFuzz, request.IncludeJazz);
        }

        if (request.Reverse)
        {
            Array.Reverse(results);
        }

        return new FizzBuzzResponse
        {
            Results = results
        };
    }

    private static string ConvertNumberToFizzBuzz(int number, bool includeFuzz, bool includeJazz)
    {
        string output = "";

        if (number % 3 == 0) output += Fizz;
        if (includeFuzz && number % 4 == 0) output += Fuzz;
        if (number % 5 == 0) output += Buzz;
        if (includeJazz && number % 9 == 0) output += Jazz;

        return output == "" ? number.ToString() : output;
    }
}
