using System;

class Dog :IAnimal,IDog
{
    public void Eat()
    {
        Console.WriteLine("먹습니다.");
    }
    public void Bark()
    {
        Console.WriteLine("짖습니다.");
    }
}
