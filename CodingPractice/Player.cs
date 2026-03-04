using System;

class Player : IDamageable
{
    public int Health { get; private set; } = 100;
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"플레이어가 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}
