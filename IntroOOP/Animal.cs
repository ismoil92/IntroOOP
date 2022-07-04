public class Animal
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public string TypeMove { get; set; }

    public Animal() { }

    public Animal(string name, int speed, string typeMove)
    {
        Name = name;
        Speed = speed;
        TypeMove = typeMove;
    }
}

public class Cat:Animal
{
    public Cat() { }
    public Cat(string name, int speed, string typeMove) : base(name, speed, typeMove) { }
}

public class Bird : Animal
{
    public Bird() { }
    public Bird(string name, int speed, string typeMove) : base(name, speed, typeMove) { }
}