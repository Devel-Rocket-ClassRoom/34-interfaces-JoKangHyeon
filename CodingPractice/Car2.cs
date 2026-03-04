using System;

class Car2
{
    IBattery _battery;

    public Car2(IBattery battery)
    {
        _battery = battery;
    }

    public void Run()
    {
        Console.WriteLine($"{_battery.GetName()}를 장착한 자동차가 달립니다.");
    }
}
