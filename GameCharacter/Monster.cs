using System;

class Monster : IAttacker, IDefender
{
    public string Name { get; set; }

    public int AttackPower { get; private set; }

    public int CurrentHp { get; private set; }

    public int MaxHp { get; private set; }

    public bool isDead => CurrentHp <= 0;

    public Monster(string name, int maxHp, int attackPower)
    {
        Name = name;
        MaxHp = maxHp;
        AttackPower = attackPower;
        CurrentHp = MaxHp;
    }

    public void Attack(IDefender target)
    {
        Console.Write($"{Name}(이/가) ");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        CurrentHp -= damage;

        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
        Console.WriteLine($"{Name}에게 {damage} 대미지! ({Name} HP: {CurrentHp}/{MaxHp})");

        if (CurrentHp == 0)
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
    }
}