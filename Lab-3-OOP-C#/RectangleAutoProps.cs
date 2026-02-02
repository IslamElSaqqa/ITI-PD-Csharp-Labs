using System;

class RectangleWithAutoProps
{
    //? Auto implemetned props 
    public double Width { get; set; } = 0;
    public double Height { get; set; } = 0;

    public string Color { get; set; } = "White";
    public string Unit { get; set; } = "cm";

    public double Area => Width * Height;


}