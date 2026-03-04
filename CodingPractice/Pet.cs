using System;

class Pet :IDog1, ICat1
{
    void IDog1.Eat()
    {
        Console.WriteLine("개처럼 먹습니다.");
    }
    void ICat1.Eat()
    {
        Console.WriteLine("고양이처럼 먹습니다.");
    }
}
