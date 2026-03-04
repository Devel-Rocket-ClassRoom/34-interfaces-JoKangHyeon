using System;

class Repository : IRepository
{
    public void Get()
    {
        Console.WriteLine("데이터를 가져옵니다.");
    }
}
