using System;
public class MyCounter
{
    private static int counter = 0;

    public  MyCounter()
    {
        counter++;
    }
    public static int GetTotalObjects()
    {
        return counter;
    }

}
