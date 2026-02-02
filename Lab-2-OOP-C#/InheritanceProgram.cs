using System;
using Microsoft.VisualBasic;

public class Employee
{
    private int id;
    private string name;
    private float baseSalary;

    public Employee() : this(1, "Unknown", 1000.0f) { }
    public Employee(int _id, string _name, float _baseSalary)
    {
        this.id = _id;
        this.name = _name;
        this.baseSalary = _baseSalary;
    }

    public Employee(int _id, string _name) : this(_id, _name, 1000.0f) { }

    //^ Properties
    public int getId() { return id; }
    public string getName() { return name; }
    public float getBaseSalary() { return baseSalary; }

    public void setId(int _id) { id = _id; }

    public void setName(string n) { name = n; }

    public void setBaseSalary(float _baseSalary){ baseSalary = _baseSalary;}
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Employee Info: \n" + id + "\nName: " + name + "\nBase-Salary" + baseSalary);
    }

    public virtual float CalculateSalary() { return baseSalary; }
}

class Manager : Employee
{
    private float bonus;
    private int teamSize;

    public Manager(int _id, string _name, float _salary)
        : base(_id, _name, _salary)
    {
        bonus = 0.0f;
        teamSize = 0;
    }

    public Manager(int _id, string _name, float _salary, float _bonus, int _teamSize)
        : base(_id, _name, _salary)
    {
        bonus = _bonus;
        teamSize = _teamSize;
    }

    // getters & setters
    public float getBonus() { return bonus; }
    public void setBonus(float b) { bonus = b; }

    public int getTeamSize() { return teamSize; }
    public void setTeamSize(int t) { teamSize = t; }

    public override float CalculateSalary()
    {
        return getBaseSalary() + bonus;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Manager Info:");
        Console.WriteLine("ID: " + getId());
        Console.WriteLine("Name: " + getName());
        Console.WriteLine("Base Salary: " + getBaseSalary());
        Console.WriteLine("Bonus: " + bonus);
        Console.WriteLine("Team Size: " + teamSize);
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
}


class Developer : Employee
{
    private string language;
    private string[] projects;

    public Developer(int _id, string _name, float _salary)
        : base(_id, _name, _salary)
    {
        language = "C#";
        projects = new string[] { "Unknown" };
    }

    public Developer(int _id, string _name, float _salary, string _language, string[] _projects)
        : base(_id, _name, _salary)
    {
        language = _language;
        projects = _projects;
    }

    public string getLanguage() { return language; }
    public void setLanguage(string l) { language = l; }

    public string[] getProjects() { return projects; }
    public void setProjects(string[] p) { projects = p; }

    public override float CalculateSalary()
    {
        return getBaseSalary() + (projects.Length * 500);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Developer Info:");
        Console.WriteLine("ID: " + getId());
        Console.WriteLine("Name: " + getName());
        Console.WriteLine("Base Salary: " + getBaseSalary());
        Console.WriteLine("Language: " + language);
        Console.WriteLine("Projects:");
        foreach (var p in projects)
            Console.WriteLine("- " + p);
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
}


class Intern : Employee
{
    private string university;
    private string duration;

    public Intern(int _id, string _name, float _salary)
        : base(_id, _name, _salary)
    {
        university = "Unknown";
        duration = "3 Months";
    }

    public Intern(int _id, string _name, float _salary, string _university, string _duration)
        : base(_id, _name, _salary)
    {
        university = _university;
        duration = _duration;
    }

    public string getUniversity() { return university; }
    public void setUniversity(string u) { university = u; }

    public string getDuration() { return duration; }
    public void setDuration(string d) { duration = d; }

    public override float CalculateSalary()
    {
        return getBaseSalary();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Intern Info:");
        Console.WriteLine("ID: " + getId());
        Console.WriteLine("Name: " + getName());
        Console.WriteLine("University: " + university);
        Console.WriteLine("Duration: " + duration);
        Console.WriteLine("Stipend: " + CalculateSalary());
    }
}

