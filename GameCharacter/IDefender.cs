using System;

interface IDefender
{
    int CurrentHp { get; }
    int MaxHp { get; }
    bool isDead { get; }
    void TakeDamage(int damage);
}
