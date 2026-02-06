using Delegates_Lab;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    delegate double CalculatorDelegate(double a, double b); // same signature as Calculator class
    delegate string Notify(string s); // same signature as Methods in MultiCast Delegate Class
    delegate bool IntFilter(int value);

    static void Main(string[] args)
    {
        double a = 10, b = 5;

        CalculatorDelegate dlg = Calculator.Add;
        double result = dlg(a, b);
        Console.WriteLine("Result: " + result);

        // Re-assign delegate to Subtract
        dlg = Calculator.Subtract;
        result = dlg(a, b);
        Console.WriteLine("Result: " + result);

        // Re-assign delegate to Multiply
        dlg = Calculator.Multiply;
        result = dlg(a, b);
        Console.WriteLine("Result: " + result);

        // Re-assign delegate to Divide
        dlg = Calculator.Divide;
        result = dlg(a, b);
        Console.WriteLine("Result: " + result);

        Console.WriteLine("********************************");

        // Multicast Delegate
        Notify notify = MultiCastDelegateClass.SendEmail; // Initial Delegate reference method
        string sendEmail = notify("Order Confirmed!");
        // Console.WriteLine(Result); // Email sent: Order Confirmed

        // Multicasting
        notify += MultiCastDelegateClass.SendSMS;
        string sendSMS = notify("Order Confirmed");
        // Console.WriteLine(sendSMS); // SMS Sent : Order Confirmed

        notify += MultiCastDelegateClass.LogToFile;
        string logToFile = notify("Order shipped");
        Console.WriteLine(logToFile); // Logged: Order Shipped

        Console.WriteLine("After Removing log to file: ");
        notify -= MultiCastDelegateClass.LogToFile; // removing Logged
        string resultAfterRemove = notify("Order shipped");
        Console.WriteLine(resultAfterRemove); // Print SMS Sent: Order shipped

        Console.WriteLine("***************************");

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        int[] evens = FilterArray(numbers, IsEven);
        int[] odds = FilterArray(numbers, IsOdd);
        int[] big = FilterArray(numbers, IsGreaterThanFive);

        printArr(evens);
        printArr(odds);
        printArr(big);

        Console.WriteLine("**************");

        // With Anonymous Method
        int[] even = FilterArray(numbers, delegate (int n) { return n % 2 == 0; });
        int[] odd = FilterArray(numbers, delegate (int n) { return n % 2 == 1; });

        Console.Write("Evens using anonymous methods: ");
        printArr(even);

        Console.Write("Odds using anonymous methods: ");
        printArr(odd);

        Console.WriteLine("********************");

        // With Lambda Expressions
        int[] bigs = FilterArray(numbers, e => e > 5);
        Console.Write("Bigs using Lambda expression: ");
        printArr(bigs);

        // use Find, FindAll and Exists with List
        List<int> integers = new() { 1, 2, 3, 4, 5, 6, 7, 8 };

        int first = integers.Find(n => n > 5); // 6
        List<int> evenIntegers = integers.FindAll(n => n % 2 == 0); // [2,4,6,8]
        bool hasNeg = integers.Exists(n => n < 0); // false

        Console.WriteLine("**************************");

        List<Person> people = new();
        
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter Name for person {i + 1}: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Enter Age for person {i + 1}: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Enter Department for person {i + 1}: ");
            string department = Console.ReadLine();
            Console.WriteLine();

            // Adding Data
            people.Add(
                new Person
                {
                    Name = name,
                    Age = age,
                    Department = department
                }
            );
        }

        Console.WriteLine("Sorting People by Age: ");

        // Sort by Age
        Console.Write("People's Age in ascending order: ");
        people.Sort((a, b) => a.Age.CompareTo(b.Age)); // Ascending
        PrintPeople(people);

        Console.Write("People's Age in descending order: ");
        people.Sort((a, b) => b.Age.CompareTo(a.Age)); // Descending
        PrintPeople(people);

        Console.WriteLine();

        Console.WriteLine("Sorting People by Name: ");

        Console.Write("People's Name in ascending order: ");
        people.Sort((a, b) => a.Name.CompareTo(b.Name)); // Ascending
        PrintPeople(people);

        Console.Write("People's Name in descending order: ");
        people.Sort((a, b) => b.Name.CompareTo(a.Name)); // Descending
        PrintPeople(people);

        Console.WriteLine();

        // Sort by multiple criteria (department and name)
        people.Sort((a, b) =>
        {
            int resultDept = a.Department.CompareTo(b.Department);
            if (resultDept != 0) return resultDept;

            return a.Name.CompareTo(b.Name);
        });

        PrintPeople(people);
        
        Console.WriteLine("******************************");
        TemperatureSensor sensor = new TemperatureSensor(); // sender

        TemperatureMonitor monitor = new TemperatureMonitor(); // listener
        Logger logger = new Logger(); // Logger

        sensor.TemperatureHigh += monitor.OnHighTemperature;
        sensor.TemperatureHigh += logger.LogTemperature;

        sensor.TemperatureLow += monitor.OnLowTemperature;
        sensor.TemperatureLow += logger.LogTemperature;

        // Trigger events
        sensor.SetTemperature(35);
        sensor.SetTemperature(5);

        // Removing logger from high temperature
        sensor.TemperatureHigh -= logger.LogTemperature;

        Console.WriteLine("\nLogger unsubscribed from High Temperature event.");

        sensor.SetTemperature(40);

        Console.WriteLine("*******************************");
        Button submitButton = new Button("Submit");

        // Handlers
        FormHandler formHandler = new FormHandler();
        ClickLogger loggerInstance = new ClickLogger();

        // Subscribe method handlers
        submitButton.Click += formHandler.OnClick;
        submitButton.Click += loggerInstance.LogClick;

        // Listening using lamda expression
        submitButton.Click += (sender, name) =>
        {
            Console.WriteLine($"Lamda Clicked: {name}");
        };

        
        submitButton.PerformClick(); // fire the submit button

        // Remove the Logger Handler using multicast
        submitButton.Click -= loggerInstance.LogClick;

        Console.WriteLine("\nLogger unsubscribed.\n");

        submitButton.PerformClick(); // fire the submit button again
    }


    private static int[] FilterArray(int[] arr, IntFilter item)
    {
        List<int> filteredArray = new();

        foreach (int element in arr)
        {
            if (item(element)) // if matches
            {
                filteredArray.Add(element);
            }
        }

        return filteredArray.ToArray(); // Shallow copy
    }

    // Without Anonymous Methods
    private static bool IsEven(int x)
    {
        return x % 2 == 0;
    }

    private static bool IsOdd(int x)
    {
        return x % 2 == 1;
    }

    private static bool IsGreaterThanFive(int x)
    {
        return x > 5;
    }

    private static void printArr(int[] numbers)
    {
        foreach (var i in numbers)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    private static void PrintPeople(List<Person> people)
    {
        foreach (var p in people)
        {
            Console.WriteLine(
                $"Person Name: {p.Name}, Person Age: {p.Age}, Person Department: {p.Department}"
            );
        }

        Console.WriteLine();
    }
}
