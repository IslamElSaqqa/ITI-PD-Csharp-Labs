using System;

class Shape
{
    public virtual double CalculateArea()
    {
        return 0; 
    }

    public virtual double CalculatePerimeter()
    {
        return 0; 
    }
}


class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}


class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}



class Triangle : Shape
{
    private double a, b, c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double CalculatePerimeter()
    {
        return a + b + c;
    }

    public override double CalculateArea()
    {
        double s = CalculatePerimeter() / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}
