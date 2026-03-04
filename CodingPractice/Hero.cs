using System;

class Hero : IMoveable, IAttackable
{
    public void Attack()
    {
        Console.WriteLine("영웅이 공격합니다.");
    }

    public void Move()
    {
        Console.WriteLine("영웅이 이동합니다.");
    }
}
