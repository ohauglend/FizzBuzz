using FizzBuzz.Interfaces;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FizzBuzzController(IFizzBuzzService fizzBuzzService) : ControllerBase
{
    /// <summary>
    /// Executes FizzBuzz with configurable rules.
    /// Standard rules (Fizz for ÷3, Buzz for ÷5) are always applied.
    /// Optional rules (Fuzz for ÷4, Jazz for ÷9) can be included via request parameters.
    /// </summary>
    /// <param name="request">FizzBuzz execution configuration</param>
    /// <returns>FizzBuzz results</returns>
    [HttpPost("execute")]
    [ProducesResponseType<FizzBuzzResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<FizzBuzzResponse> Execute([FromBody] FizzBuzzRequest request)
    {
        try
        {
            var result = fizzBuzzService.Generate(request);
            return Ok(result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
