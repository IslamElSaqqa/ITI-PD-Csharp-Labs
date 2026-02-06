using System;
public class TemperatureMonitor
{
    public void OnHighTemperature(string message, double temperature)
    {
        Console.WriteLine($"Monitor Alert: {temperature}°C - {message}");
    }

    public void OnLowTemperature(string message, double temperature)
    {
        Console.WriteLine($"Monitor Alert: {temperature}°C - {message}");
    }
}


