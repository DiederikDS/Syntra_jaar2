using ReadFileOefening;

Console.WriteLine("Typ het pad naar de gewenste directory");
string path = Console.ReadLine();

DirectoryReader directoryReader = new DirectoryReader(path);
FileReader fileReader = new FileReader(@"C:\Users\diede\OneDrive\Bureaublad\TestFolder");
ConsoleKey answer;

directoryReader.AddFiles();
Console.WriteLine("Inhoud Map:");
foreach (string file in directoryReader.Files)
{
    Console.WriteLine(file);
}

Console.WriteLine("\nWil je de inhoud van het de eerste file zien? Typ \"y\" voor ja");
answer = Console.ReadKey().Key;
if (answer == ConsoleKey.Y)
{
    fileReader.ReadFile();
}

foreach(string file in fileReader.FileContent)
{
    Console.WriteLine(file);
}