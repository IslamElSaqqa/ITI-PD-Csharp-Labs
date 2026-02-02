using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;


public class MyDate
{
    private int YY, MM, DD;
    public MyDate() : this(1990, 1, 1) { }
    public MyDate(int Y, int M)
    {
        YY = Y;
        MM = M;
        DD = 1;
    }
    public MyDate(int YY, int MM, int DD)
    {
        this.YY = YY;
        this.MM = MM;
        this.DD = DD;
    }

    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public void PrintDate()
    {
        Console.WriteLine("Date Info: ");
        Console.WriteLine("Year: " + YY);
        Console.WriteLine("Month: " + MM);
        Console.WriteLine("Day: " + DD);
    }
    
}


class Program
{
    public static void Main(string[] args)
    {
        MyDate d1 = new MyDate(2026, 1, 2);
        MyDate d2 = new MyDate();
        d2.Day = 2; d2.Month = 1; d2.Year = 2026;
        Console.WriteLine("Tomorrow's Date");
        Console.WriteLine("----------------");
        d2.PrintDate();

        MyDate d3 = new MyDate(2027, 1);
        Console.WriteLine("Next Year's Date");
        Console.WriteLine("----------------");
        d3.PrintDate();
        Console.WriteLine("----------------");

        MyCounter c1 = new MyCounter();
        MyCounter c2 = new MyCounter();
        MyCounter c3 = new MyCounter();

        Console.WriteLine("Total Objects Created: " + MyCounter.GetTotalObjects());

        Console.WriteLine("----------------------");

        Employee e = new Employee(1, "Ahmed", 3000);
        Manager m = new Manager(2, "Sara", 6000, 2000, 10);
        Developer d = new Developer(
            3,
            "Omar",
            5000,
            "C#",
            new string[] { "ERP System", "E-Commerce App" }
        );
        Intern i = new Intern(4, "Mona", 1500, "Cairo University", "6 Months");

        Employee[] staff = { e, m, d, i };

        foreach (Employee emp in staff)
        {
            emp.DisplayInfo();
            Console.WriteLine("-------------------------");
        }
        Console.WriteLine("---------------------------------");
        Shape s1 = new Circle(5);
        Shape s2 = new Rectangle(4, 6);
        Shape s3 = new Triangle(3, 4, 5);

        Console.WriteLine(s1.CalculateArea());
        Console.WriteLine(s2.CalculateArea());
        Console.WriteLine(s3.CalculateArea());

        Console.WriteLine(s1.CalculatePerimeter());
        Console.WriteLine(s2.CalculatePerimeter());
        Console.WriteLine(s3.CalculatePerimeter());

        Console.WriteLine("----------------------------------");
        
        Animal a1 = new Dog();
        Animal a2 = new Cat();
        Animal a3 = new Bird();

        a1.MakeSound();
        a1.Move();

        a2.MakeSound();
        a2.Move();

        a3.MakeSound();
        a3.Move();

        Console.WriteLine("----------------------------------");
        IMovable car = new Car();
        car.Move();
        Console.WriteLine("Car speed: " + car.GetSpeed());
        car.Stop();

        Console.WriteLine("------------------");

        Robot robot = new Robot();
        robot.Move();
        Console.WriteLine("Robot speed: " + robot.GetSpeed());
        Console.WriteLine("Battery: " + robot.GetBatteryLevel());
        robot.Stop();
        robot.Charge();

        Console.WriteLine("-----------------------------------");
        Student s = new Student();

        s.Name = "Ahmed";  
        s.Age = 20;         

        Console.WriteLine(s.Name); 
        Console.WriteLine(s.Age);  

        s.Age = 10;

        Console.WriteLine("Final Age: " + s.Age);


        Console.WriteLine("------------------------------------");

        SavingsAccount savings = new SavingsAccount("Alice", 1000, 5); 
        savings.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Depositing 500 into Savings Account...");
        savings.Deposit(500);
        savings.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Withdrawing 700 from Savings Account...");
        savings.Withdraw(700);
        savings.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Withdrawing 400 from Savings Account (below minimum)...");
        savings.Withdraw(400); 
        savings.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Applying interest to Savings Account...");
        savings.ApplyInterest();
        savings.PrintDetails();
        Console.WriteLine();

        CheckingAccount checking = new CheckingAccount("Bob", 200);
        checking.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Depositing 300 into Checking Account...");
        checking.Deposit(300);
        checking.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Withdrawing 600 from Checking Account...");
        checking.Withdraw(600); 
        checking.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Withdrawing 1200 from Checking Account...");
        checking.Withdraw(1200); 
        checking.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Performing multiple withdrawals to check transaction count...");
        checking.Withdraw(50);
        checking.Withdraw(50);
        checking.Withdraw(50); 
        checking.PrintDetails();
        Console.WriteLine();


    
    }
}

