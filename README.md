# Unit Tests Examples for C#

## Getting Started

- Install [.NET SDK 6](https://dotnet.microsoft.com/download/dotnet/6.0)
- Install vs code extension `ms-dotnettools.csharp`.
- Install [XUnit](https://xunit.net/)

## Run All Tests

- In a terminal, run `dotnet test`.

## Run/debug one test/class

- Open the file with the test / class to run.
- Above the test method or class definition, there should be a `Run Test` or `Debug Test` code action.

## Visual Studio Code extensions

- [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer) - Discovers tests and gives you a nice explorer.

## About Unit Testing

- Unit tests verify business logic behavior and protect from introducing unnoticed breaking changes in the future.
- The business logic has input parameters (that need to be simulated), and output parameters that need to be verified.

## Unit Testing Best Practices

- Each test should have a single responsibility with no logic in them (no control structures).
- Test the outcome of a function with at least as many tests as execution paths the function has.
- Never test language features or third party's code.
- Every test should be falsifiable.

## Useful libraries

- [Moq](https://github.com/moq/moq4): A way to quickly setup dependencies (mocks) for your tests.
- [Fluent Assertions](https://fluentassertions.com/introduction): A set of extension methods that allows you to more naturally specify the expected outcome of tests.
- [Bogus](https://github.com/bchavez/Bogus): A fake data generator for C#. Based on and ported from faker.js.

## XUnit Tests Patterns

- Facts are tests which are always true. They test invariant conditions.
- Theories are tests which are only true for a particular set of data.

## Examples

- [XUnit Examples](https://github.com/xunit/samples.xunit)

```csharp
using Xunit;

namespace UnitTests {
  // Name of the class that will be tested:
  public class PrimeServiceUnitTesting {
    [Fact]
    // Naming convention [MethodName]_[Scenario]_[ExpectedBehavior]
    // Example:
    public void IsPrime_InputIs1_ReturnFalse() {
      // Arrange: Initialize objects and prepare what is going to be tested
      PrimeService primeService = new();

      // Act: Call the method on the object that needs to be tested
      bool result = primeService.IsPrime(1);

      // Assert: Verify that the result is correct
      Assert.False("1 should not be prime", result);
    }
  }

  // Name of the class that will be tested:
  public class OddServiceUnitTesting {
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(6)]
    // Naming convention [MethodName]_[Scenario]_[ExpectedBehavior]
    // Example:
    public void IsOdd_WhenCalled_ReturnWetherTheNumberIsOdd(int number) {
      // Arrange: Initialize objects and prepare what is going to be tested
      OddService oddService = new();

      // Act: Call the method on the object that needs to be tested
      bool result = oddService.IsOdd(number);

      // Assert: Verify that the result is correct
      Assert.True($"{number} should be odd", result);
    }
  }
}
```
