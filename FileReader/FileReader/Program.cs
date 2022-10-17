using FileReader.Classes;

DirectoryExplorer de = new DirectoryExplorer();
de.GetItems(@"C:\Users\Diederik\Desktop");

foreach(var i in de.Items)
{
    Console.WriteLine(i);
}

//--------------------------------------------------------------------

TxtFileReader fr = new TxtFileReader();

fr.ReadFile(@"C:\Users\Diederik\Desktop\Testdoc.txt");

foreach (var item in fr.Lines)
{
    Console.WriteLine(item);
}