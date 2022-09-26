using OefeningSpecialList.Classes;

SpecialList<string> list = new SpecialList<string>();

list.Add("Generic");
list.Add("Generic1");
list.Add("Generic2");
list.Add("Generic3");

Console.WriteLine(list.GetItemByIndex(2));
Console.WriteLine(list.GetCount());
list.RemoveItem("Generic2");
Console.WriteLine(list.GetItemByIndex(2));