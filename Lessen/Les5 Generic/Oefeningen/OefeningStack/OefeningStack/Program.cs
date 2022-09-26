using OefeningStack.Classes;

MyStack<int> Stack = new MyStack<int>();

Stack.Add(0);
Stack.Add(1);
Stack.Add(2);
Stack.Add(3);

Console.WriteLine(Stack.Peek());

Console.WriteLine(Stack.Remove());

Console.WriteLine(Stack.Peek());

