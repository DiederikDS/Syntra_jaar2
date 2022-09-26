using OefeningStack.Classes;

MyStack<string> Stack = new MyStack<string>();

Stack.Add("Generic");
Stack.Add("Generic1");
Stack.Add("Generic2");
Stack.Add("Generic3");

Console.WriteLine(Stack.Peek());

Console.WriteLine(Stack.Remove());

Console.WriteLine(Stack.Peek());

