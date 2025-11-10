using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Interfaces;

public interface IFizzBuzzService
{
    FizzBuzzResponse Generate(FizzBuzzRequest request);
}
