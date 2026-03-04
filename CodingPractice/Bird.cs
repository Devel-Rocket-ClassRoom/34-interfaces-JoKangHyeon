using System;

class Bird : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("날아갑니다.");
    }
}
