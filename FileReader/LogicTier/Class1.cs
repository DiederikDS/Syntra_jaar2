namespace LogicTier
{
    public class TxtFileReader
    {
        public string[] Lines { get; set; }

        public TxtFileReader()
        {

        }

        public void ReadFile(string location)
        {
            Lines = (string[])File.ReadAllLines($@"{location}");
        }
    }

    public class DirectoryExplorer
    {
        public string[] Items { get; set; }

        public DirectoryExplorer()
        {

        }

        public void GetItems(string location)
        {
            string[] empty = new string[0];
            Items = empty;
            Items = Directory.GetFiles(@$"{location}");
        }
    }
}