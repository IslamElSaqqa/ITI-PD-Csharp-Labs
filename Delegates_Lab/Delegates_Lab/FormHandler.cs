using System;

public class FormHandler
{
    // Event handler
    public void OnClick(object sender, string buttonName)
    {
        Console.WriteLine($"Form Handling click on button: {buttonName}");
    }
}

