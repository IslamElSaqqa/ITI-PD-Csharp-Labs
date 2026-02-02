using System;

class ResourceFileException
{
    private string fileName;
    private bool isOpen = false;

    public ResourceFileException(string fileName)
    {
        this.fileName = fileName;
    }

    public void Open()
    {
        Console.WriteLine($"Opening file: {fileName}");
        isOpen = true;
    }

    public string Read()
    {
        if (!isOpen)
            throw new InvalidOperationException("File is not open.");

        throw new Exception("Read error occurred!");
    }

    public void Close()
    {
        Console.WriteLine($"Closing file: {fileName}");
        isOpen = false;
    }
}
