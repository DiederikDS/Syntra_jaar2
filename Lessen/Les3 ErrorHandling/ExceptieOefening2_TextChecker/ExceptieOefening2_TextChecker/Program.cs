using ExceptieOefening2_TextChecker.Classes;

string FilePath = @"C:\Users\diede\OneDrive\Bureaublad\Syntra_jaar2\Lessen\Les3 ErrorHandling\ExceptieOefening2_TextChecker\ExceptieOefening2_TextChecker\Files\ErrorLogs.txt";

void TestTextChecker(string input)
{
    try
    {
        TextChecker.CheckText(input);
    }
    catch (ContainsLetterFException e)
    {

        //Console.WriteLine($"\"{e.Message}\" fails because: {e.Error}");
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine($"\"{e.Message}\" fails because: {e.Error}");
        }
    }
    catch (ContainsAlotException e)
    {
        //Console.WriteLine($"\"{e.Message}\" fails because: {e.Error}");
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine($"\"{e.Message}\" fails because: {e.Error}");
        }
    }
    catch (ContainsNumberException e)
    {
        //Console.WriteLine($"\"{e.Message}\" fails because: {e.Error}");
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine($"\"{e.Message}\" fails because: {e.Error}");
        }
    }
}

//TestTextChecker("This contains 1");
TestTextChecker("This contains f");
//TestTextChecker("This input is very loooooooooooooooooooooooooooooooooooooooooooooooooong");


