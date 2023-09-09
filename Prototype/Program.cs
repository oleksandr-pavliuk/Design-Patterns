IAnimal animal = new Cat("Barsik", "Grey", "Male");
IAnimal clonedCat = animal.Clone();
animal.GetInfo();
clonedCat.GetInfo();

animal = new Dog("Bobik", "Dark");
IAnimal clonedDog = animal.Clone();
animal.GetInfo();
clonedDog.GetInfo();
Console.Read();



public interface IAnimal                             // Main interface for cloneable classes
{
    IAnimal Clone();
    void GetInfo();
}

public class Cat : IAnimal
{
    public string Name { get; private set; }
    public string Color { get; private set; }
    public string Gender { get; private set; }

    public Cat(string name, string color, string gender)
    {
        Name = name;
        Color = color;
        Gender = gender;
    }

    public IAnimal Clone()                           // Method for cloning CAT
    {
        return new Cat(Name, Color, Gender);
    }

    public void GetInfo()
    {
        Console.WriteLine($"CAT : Name -> {Name}  Color -> {Color}  Gender -> {Gender}");
    }
}

public class Dog : IAnimal                           
{
    public string Name { get; private set; }
    public string Color { get; private set; }
    public Dog(string name, string color) 
    {
        Name = name;
        Color = color;
    }

    public IAnimal Clone()                          // Method for cloning DOG
    {
        return new Dog(Name, Color);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Dog: Name -> {Name}  Color -> {Color}");
    }
}