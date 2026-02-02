using System;

class Student
{
    private int age;
    private string? name;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 16 && value <= 100)
                age = value;
            else
                Console.WriteLine("Invalid age! Must be between 16 and 100.");
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty.");
        }
    }
}
