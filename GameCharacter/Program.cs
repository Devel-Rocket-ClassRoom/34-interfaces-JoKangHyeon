using System;

Character hero = new Character("용사");
Monster slime = new Monster("슬라임", 30, 5);

Console.WriteLine("=== 전투 시작 ===");
Console.WriteLine();
ProcessBattle(hero, slime);
ProcessBattle(slime, hero);
ProcessBattle(hero, slime);


Monster gobblin = new Monster("고블린", 50, 10);

Console.WriteLine();
Console.WriteLine("=== 고블린 등장 ===");
Console.WriteLine();
ProcessBattle(hero,gobblin);
ProcessBattle(gobblin, hero);
ProcessBattle(hero, gobblin);
ProcessBattle(hero, gobblin);


void ProcessBattle(IAttacker attacker, IDefender defender)
{
    attacker.Attack(defender);
}
