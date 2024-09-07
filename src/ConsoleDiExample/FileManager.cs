namespace ConsoleDiExample;

public class FileManager(IFileReader fileReader, IFileWriter fileWriter)
{
    private const string FilePath = "test.txt";

    public void ReadFile()
    {
        var text = fileReader.ReadFile(FilePath);
        Console.WriteLine(text);
    }

    public void WriteFile(string text)
    {
        fileWriter.WriteFile(FilePath, text);
    }
}