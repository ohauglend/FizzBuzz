using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Services;

public interface IFizzBuzzService
{
    FizzBuzzResponse Generate(FizzBuzzRequest request);
}
