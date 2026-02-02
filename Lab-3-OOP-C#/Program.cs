using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var P1 = new Person
        {
            FirstName = "Islam",
            LastName = "Elsaqqa",
            Age = 21
        };

        var P2 = new Person
        {
            FirstName = "Cristiano",
            LastName = "Ronaldo",
            Age = 41
        };

        Console.WriteLine($"Person 1: FirstName: {P1.FirstName}, LastName: {P1.LastName}, Age: {P1.Age}");
        Console.WriteLine($"Person 2: FirstName: {P2.FirstName}, LastName: {P2.LastName}, Age: {P2.Age}");

        Console.WriteLine("------------------------");

        var R1 = new RectangleWithAutoProps();
        R1.Width = 10.5;
        R1.Height = 11.9;

        Console.WriteLine("Setting Values using props for Rectangle 1:");
        Console.WriteLine($"R1 -> Width: {R1.Width}, Height: {R1.Height}");
        Console.WriteLine($"R1 -> Default Color: {R1.Color}, Default Unit: {R1.Unit}");
        Console.WriteLine($"R1 -> Area: {R1.Area} in {R1.Unit}");

        var R2 = new RectangleWithAutoProps();
        R2.Width = 20.0;
        R2.Height = 10.0;
        R2.Color = "Black";
        R2.Unit = "inches";

        Console.WriteLine("Setting Values using props for Rectangle 2:");
        Console.WriteLine($"R2 -> Width: {R2.Width}, Height: {R2.Height}");
        Console.WriteLine($"R2 -> Color: {R2.Color}, Unit: {R2.Unit}");
        Console.WriteLine($"R2 -> Area: {R2.Area} in {R2.Unit}");

        Console.WriteLine("--------------------------------------");

        var grades = new StudentGradeBook(5);
        grades[0] = 90;
        grades[1] = 50;
        grades[2] = 40;
        grades[3] = 85;
        grades[4] = 70;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Grades: {grades[i]}");
        }

        Console.WriteLine("-----------------------");

        var collection = new StringCollectionIndexer();
        collection[0] = "First";
        collection[1] = "Second";
        collection["server"] = "localhost";
        collection["port"] = "8080";

        Console.WriteLine(collection["server"]);

        Console.WriteLine("---------------------------");

        ArrayList cart = new ArrayList();
        cart.Add(42);
        cart.Add("Hello");
        cart.Add(3.14);
        cart.Add(DateTime.Now);
        cart.Add("Islam");

        cart.Remove("Hello");
        int findIslamPosition = cart.IndexOf("Islam");
        Console.WriteLine("Islam is found at location " + findIslamPosition);

        foreach (var item in cart)
        {
            Console.WriteLine("ArrayList item: " + item);
        }

        Console.WriteLine("----------------------------");

        var students = new List<Student>
        {
            new Student { Id = 1, Name = "Ahmed", GPA = 3.50f },
            new Student { Id = 2, Name = "Sara", GPA = 3.80f },
            new Student { Id = 2, Name = "Sara", GPA = 3.90f },
            new Student { Id = 2, Name = "Sara", GPA = 3.85f },
            new Student { Id = 3, Name = "Omar", GPA = 3.20f }
        };

        var found = students.Find(s => s.GPA > 3.5f);
        Console.WriteLine("First student with GPA > 3.5: " + found);

        List<Student> honors = students.FindAll(s => s.GPA >= 3.5f);
        foreach (var std in honors)
        {
            Console.WriteLine("High honors: " + std);
        }

        students.Sort((a, b) => b.GPA.CompareTo(a.GPA));

        Console.WriteLine("------------------");

        Calculator calc = new Calculator();

        try
        {
            double result = calc.Divide(10, 0);
            Console.WriteLine("Result: " + result);

            int sum = calc.ParseAndAdd("10", "Mohamed");
            Console.WriteLine("Sum: " + sum);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large!");
        }
        catch (Exception)
        {
            Console.WriteLine("Unknown error!");
        }

        Console.WriteLine("--------------------------------------");

        var file = new ResourceFileException("islam.txt");

        try
        {
            file.Open();
            string ReadData = file.Read();
            Console.WriteLine(ReadData);
        }
        catch (Exception err) //? General Exception
        {
            Console.WriteLine($"Error: {err.Message}");
        }
        finally
        {
            file.Close(); //? Closing the file for both situations
        }
    }

}
