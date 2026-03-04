using System;

class Character : IAttacker, IDefender
{
    public string Name { get; set; }
    
    public int AttackPower { get; private set; } = 20;

    public int CurrentHp { get; private set; }

    public int MaxHp { get; private set; } = 100;

    public bool isDead => CurrentHp>0;

    public Character(string name){
        Name = name;
        CurrentHp = MaxHp;
    }

    public void Attack(IDefender target)
    {
        Console.Write($"{Name}(이/가) ");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        CurrentHp-=damage;

        if (CurrentHp < 0)
        {
            CurrentHp = 0;
        }
        Console.WriteLine($"{Name}에게 {damage} 대미지! ({Name} HP: {CurrentHp}/{MaxHp})");
        
        if(CurrentHp==0)
            Console.WriteLine($"{Name}(이/가) 쓰러졌습니다!");
    }
}
