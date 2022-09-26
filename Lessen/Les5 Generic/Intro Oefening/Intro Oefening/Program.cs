using Intro_Oefening.Classes;

var MyQueue = new MyQueue<String>();

MyQueue.Add("MyFirstGeneric");
MyQueue.Add("MyFirstGeneric1");
MyQueue.Add("MyFirstGeneric2");
MyQueue.Add("MyFirstGeneric3");

Console.WriteLine(MyQueue.Peek());
Console.WriteLine(MyQueue.Remove());
Console.WriteLine(MyQueue.Peek());
