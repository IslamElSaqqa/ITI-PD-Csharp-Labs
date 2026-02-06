using System;
public class ClickLogger
{
    public void LogClick(object sender, string buttonName)
    {
        Console.WriteLine($"Logger Button clicked: {buttonName}");
    }
}
