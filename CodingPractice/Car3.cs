using System;

class Car3 : Vehicle, IStandard
{
    public override void Back()
    {
        Console.WriteLine("후진");
    }
    public void Run()
    {
        Console.WriteLine("전진");
    }
}
