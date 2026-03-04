using System;

class Example : IExample
{
    void IExample.DoWork()
    {
        Console.WriteLine("작업 수행");
    }
}
