using System;

abstract class Animal
{
    public abstract void MakeSound(); 
    public abstract void Move();     
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public override void Move()
    {
        Console.WriteLine("Running on four legs!");
    }
}


class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override void Move()
    {
        Console.WriteLine("Walking gracefully!");
    }
}


class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp! Chirp!");
    }

    public override void Move()
    {
        Console.WriteLine("Flying in the sky!");
    }
}
