using Stack;

StackOfStrings stack = new StackOfStrings();

stack.Push("Element 1");
stack.Push("Element 2");
stack.Push("Element 3");

Console.WriteLine("Peek: " + stack.Peek());

while (!stack.IsEmpty())
{
    Console.WriteLine("Pop: " + stack.Pop());
}