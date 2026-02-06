using System;

public delegate void ClickHandler(object sender, string buttonName);

public class Button
{
    private string name;

    public event ClickHandler Click; // Click handler event

    public Button(string name)
    {
        this.name = name;
    }

    public void PerformClick() // fires the event
    {
        Console.WriteLine($"\nButton [{name}] was clicked.");

        if (Click != null)  
                Click(this, name); // this is the sender, name is the string (button name)
    
        }
}

