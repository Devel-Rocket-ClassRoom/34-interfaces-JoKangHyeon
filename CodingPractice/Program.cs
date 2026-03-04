using System;

Console.WriteLine();
Console.WriteLine("### 1-1. 기본 구현");

ICar c = new Car();
c.Go();



Console.WriteLine();
Console.WriteLine("### 1-2. 인터페이스 형식의 변수");

IRepository repository = new Repository();
repository.Get();



Console.WriteLine();
Console.WriteLine("### 1-3. 구현 클래스의 규칙");

IPerson person = new Person();
person.Work();
person.Rest();



Console.WriteLine();
Console.WriteLine("## 2. 생성자 매개변수에 인터페이스 사용");

Car2 car21 = new Car2(new GoodBattery());
Car2 car22 = new Car2(new NormalBattery());

car21.Run();
car22.Run();



Console.WriteLine();
Console.WriteLine("### 3-1. 여러 인터페이스 구현하기");

Dog dog = new Dog();
dog.Eat();
dog.Bark();



Console.WriteLine();
Console.WriteLine("### 3-2. 클래스 상속과 인터페이스 구현 함께 사용");

Bird bird = new Bird();
bird.Breathe();
bird.Fly();



Console.WriteLine();
Console.WriteLine("### 4-1. 이름 충돌 해결");

Pet pet = new Pet();

((IDog1)pet).Eat();
((ICat1)pet).Eat();

IDog1 dog1 = pet;
ICat1 cat1 = pet;
dog1.Eat();
cat1.Eat();



Console.WriteLine();
Console.WriteLine("### 4-2. 명시적 구현의 특징");

Example example = new Example();
IExample example1 = example;
example1.DoWork();



Console.WriteLine();
Console.WriteLine("## 5. 인터페이스 상속");

TextEditor textEditor = new TextEditor();
textEditor.Undo();
textEditor.Redo();



Console.WriteLine();
Console.WriteLine("## 6. 인터페이스와 추상 클래스 비교");

Car3 car = new Car3();
car.Run();
car.Left();
car.Back();



Console.WriteLine();
Console.WriteLine("### 7-1. 대미지 시스템");

Player player = new Player();
Enemy enemy = new Enemy();
Building building = new Building();

Attack(player,20);
Attack(enemy, 30);
Attack(building, 100);


void Attack(IDamageable target, int damage)
{
    target.TakeDamage(damage);
}



Console.WriteLine();
Console.WriteLine("### 7-2. 다중 인터페이스로 기능 조합");

Hero hero = new Hero();
Turret turret = new Turret();

hero.Move();
hero.Attack();
turret.Attack();
