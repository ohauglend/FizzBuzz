# FizzBuzz Web API

A .NET Web API implementation of the FizzBuzz game with configurable rules.

## Core Rules

- **Fizz**: Numbers divisible by 3
- **Buzz**: Numbers divisible by 5
- **FizzBuzz**: Numbers divisible by both 3 and 5 (e.g., 15 → "FizzBuzz")

## Optional Rules

Users can enable additional rules via the API:

- **Fuzz**: Numbers divisible by 4
- **Jazz**: Numbers divisible by 9
- **Reverse**: Output in descending order

Rules apply additively. Example: `36` with all rules → "FizzFuzzJazz"

## Project Structure

```plaintext
FizzBuzz/
├── src/
│   └── FizzBuzz.Web/
│       ├── Components/      # Blazor components
│       ├── Models/          # Request/Response models
│       ├── Services/        # Business logic
│       └── Program.cs       # App entry point
└── tests/
    └── FizzBuzz.Tests/      # Unit tests
```

## Quick Start

```powershell
# Run the web app
dotnet run --project src/FizzBuzz.Web

# Run tests
dotnet test
```

Web app available at `http://localhost:5000`
