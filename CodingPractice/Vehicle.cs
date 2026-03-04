using System;

abstract class Vehicle
{
    public abstract void Back();
    public void Left()
    {
        Console.WriteLine("좌회전");
    }
}
