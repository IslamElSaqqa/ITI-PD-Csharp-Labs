interface IMovable
{
    void Move();
    void Stop();
    int GetSpeed();
}

interface IChargeable
{
    void Charge();
    int GetBatteryLevel();
}


class Car : IMovable
{
    private int speed;

    public void Move()
    {
        speed = 60;
        Console.WriteLine("Car is moving at 60 km/h");
    }

    public void Stop()
    {
        speed = 0;
        Console.WriteLine("Car stopped");
    }

    public int GetSpeed()
    {
        return speed;
    }
}


class Robot : IMovable, IChargeable
{
    private int speed;
    private int batteryLevel;

    public Robot()
    {
        batteryLevel = 100;
    }

    // IMovable
    public void Move()
    {
        if (batteryLevel > 0)
        {
            speed = 10;
            batteryLevel -= 10;
            Console.WriteLine("Robot is moving");
        }
        else
        {
            Console.WriteLine("Battery empty! Cannot move.");
        }
    }

    public void Stop()
    {
        speed = 0;
        Console.WriteLine("Robot stopped");
    }

    public int GetSpeed()
    {
        return speed;
    }

    // IChargeable
    public void Charge()
    {
        batteryLevel = 100;
        Console.WriteLine("Robot fully charged");
    }

    public int GetBatteryLevel()
    {
        return batteryLevel;
    }
}
