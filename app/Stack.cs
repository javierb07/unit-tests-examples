// Normally, the class that we want to test would exist in a different namespace
namespace Stack.UnitTests {
  public class Stack<T> {
    private readonly List<T> _list = new();
    public int Count => _list.Count;

    public void Push(T obj) {
      if (obj == null) { throw new ArgumentNullException(); }

      _list.Add(obj);
    }

    public T Pop() {
      if (_list.Count == 0) { throw new InvalidOperationException(); }
      T result = _list[^1];
      _list.RemoveAt(_list.Count - 1);

      return result;
    }

    public T Peek() {
      if (_list.Count == 0) { throw new InvalidOperationException(); }

      return _list[^1];
    }

    public bool Contains(T value) {
      if (_list.Count == 0) { throw new InvalidOperationException(); }

      return _list.Contains(value);
    }
  }
}