namespace Stack.UnitTests {
  public class StackTests {
    [Fact]
    public void Push_ArgIsNull_ThrowArgNullException() {
      // Arrange 
      Stack<string> stack = new();

      // Act
      Action act = () => stack.Push(null!);

      // Assert
      act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void Push_ValidArg_AddTheObjectToTheStack() {
      // Arrange 
      Stack<string> stack = new();

      // Act
      stack.Push("a");

      // Assert
      stack.Count.Should().Be(1);
    }

    [Fact]
    public void Count_EmptyStack_ReturnZero() {
      // Arrange 
      Stack<string> stack = new();

      // Act -> No actions

      // Assert
      stack.Count.Should().Be(0);
    }

    [Fact]
    public void Pop_EmptyStack_ThrowInvalidOperationException() {
      // Arrange 
      Stack<string> stack = new();

      // Act
      Action act = () => stack.Pop();

      // Assert
      act.Should().Throw<InvalidOperationException>();
    }

    [Fact]
    public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop() {
      // Arrange 
      Stack<string> stack = new();
      stack.Push("a");
      stack.Push("b");
      stack.Push("c");

      // Act
      string result = stack.Pop();

      // Assert
      result.Should().Be("c");
    }

    [Fact]
    public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop() {
      // Arrange 
      Stack<string> stack = new();
      stack.Push("a");
      stack.Push("b");
      stack.Push("c");

      // Act
      stack.Pop();

      // Assert
      stack.Count.Should().Be(2);
    }

    [Fact]
    public void Peek_EmptyStack_ThrowInvalidOperationException() {
      // Arrange 
      Stack<string> stack = new();

      // Act
      Action act = () => stack.Peek();

      // Assert
      act.Should().Throw<InvalidOperationException>();
    }

    [Fact]
    public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack() {
      // Arrange 
      Stack<string> stack = new();
      stack.Push("a");
      stack.Push("b");
      stack.Push("c");

      // Act
      string result = stack.Peek();

      // Assert
      result.Should().Be("c");
    }

    [Fact]
    public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack() {
      // Arrange 
      Stack<string> stack = new();
      stack.Push("a");
      stack.Push("b");
      stack.Push("c");

      // Act
      stack.Peek();

      // Assert
      stack.Count.Should().Be(3);
    }

    [Theory]
    [InlineData("a")]
    [InlineData("b")]
    [InlineData("c")]
    public void Contains_StackWithObjects_DeterminesIfTheValueIsInTheStack(string value) {
      // Arrange 
      Stack<string> stack = new();
      stack.Push("a");
      stack.Push("b");
      stack.Push("c");

      // Act
      bool result = stack.Contains(value);

      // Assert
      result.Should().BeTrue();
    }
  }
}