Stack myStack = new Stack();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
myStack.Push(5);

Console.Write("Number of elements in Stack: {0}", myStack.Count);

while (myStack.Count > 0)
     Console.WriteLine(myStack.Pop());

Console.Write("Number of elements in Stack: {0}", myStack.Count);