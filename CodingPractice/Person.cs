using System;

class Person :IPerson
{
    public void Work()
    {
        Console.WriteLine("일을 합니다.");
    }
    public void Rest()
    {
        Console.WriteLine("휴식을 취합니다.");
    }
}
