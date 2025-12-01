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
# Build the solution
dotnet build

# Run the web app (preferred method)
dotnet run --project src/FizzBuzz.Web

# Alternative:Set environment to Development and run DLL directly (only needed if exe is blocked by organization policy)
$env:ASPNETCORE_ENVIRONMENT='Development'; dotnet src/FizzBuzz.Web/bin/Debug/net9.0/FizzBuzz.Web.dll

# Run tests
dotnet test
```

Web app available at `http://localhost:5000`
