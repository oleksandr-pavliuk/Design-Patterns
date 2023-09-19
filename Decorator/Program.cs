Auto auto1 = new MercedesAuto();
Auto auto2 = new BmwAuto();

auto1 = new AutoBusiness(auto1);
auto2 = new AutoSport(auto2);
Console.WriteLine($"Name : {auto1.Name} \nPrice : {auto1.GetCost()}");
Console.WriteLine($"Name : {auto2.Name} \nPrice : {auto2.GetCost()}");

public abstract class Auto
{
    public Auto(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public abstract int GetCost();
}

public class MercedesAuto : Auto
{
    public MercedesAuto() : base("Mercedes Standart")
    {
        
    }

    public override int GetCost()
    {
        return 30000;
    }
}

public class BmwAuto : Auto
{
    public BmwAuto() : base("BMW Standart")
    {

    }

    public override int GetCost()
    {
        return 25000;
    }
}

public abstract class AutoDecorator : Auto
{
    protected Auto auto;

    public AutoDecorator(string newAuto, Auto auto) : base(newAuto)
    {
        
    }
}

public class AutoBusiness : AutoDecorator
{
    public AutoBusiness(Auto auto) : base(auto.Name + " business class", auto)
    {
        
    }

    public override int GetCost()
    {
        return auto.GetCost() + 20000;
    }
}

public class AutoSport : AutoDecorator
{
    public AutoSport(Auto auto) : base(auto.Name + " sport class", auto)
    {
        
    }

    public override int GetCost()
    {
        return auto.GetCost() + 30000;
    }
}