namespace ConsoleDiExample;

public class FileWriter : IFileWriter
{
    public void WriteFile(string filePath, string text)
    {
        File.WriteAllText(filePath, text);
    }
}