public class FileLoggerAdapter : Logger
{
    private readonly FileWriter _fileWriter;

    public FileLoggerAdapter(string path)
    {
        _fileWriter = new FileWriter(path);
    }

    public new void Log(string message)
    {
        _fileWriter.WriteLine($"LOG: {message}");
    }

    public new void Error(string message)
    {
        _fileWriter.WriteLine($"ERROR: {message}");
    }

    public new void Warn(string message)
    {
        _fileWriter.WriteLine($"WARNING: {message}");
    }
}