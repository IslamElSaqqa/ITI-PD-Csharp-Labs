using System;


public delegate void TemperatureHandler(string message, double temperature);

public class TemperatureSensor
{
    // Event Delegates
    public event TemperatureHandler TemperatureHigh;
    public event TemperatureHandler TemperatureLow;

    public void SetTemperature(double temp)
    {
        Console.WriteLine($"\nSensor reading: {temp}°C");

        if (temp > 30)
        {
            if (TemperatureHigh != null)
                    TemperatureHigh("High temperature warning!", temp);
        }
        else if (temp < 10)
        {   
               if(TemperatureLow != null)
                    TemperatureLow("Low temperature warning!", temp);
        }
    }
}


