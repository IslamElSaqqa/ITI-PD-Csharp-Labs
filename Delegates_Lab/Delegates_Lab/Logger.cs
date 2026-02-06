using System;
public class Logger
{
    public void LogTemperature(string message, double temperature)
    {
        Console.WriteLine($"Logger: {DateTime.Now} - {temperature}°C - {message}");
    }
}

