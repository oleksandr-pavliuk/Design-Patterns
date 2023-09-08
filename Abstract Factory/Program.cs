IFactory factory = new JapaneseFactory();
var car = factory.CreateCar();
var engine = factory.CreateEngine();
car.CreateCar(engine);

factory = new AmericanFactory();
car = factory.CreateCar();
engine = factory.CreateEngine();
car.CreateCar(engine);


public interface IEngine
{
    void ReleaseEngine();
}

class JapaneseEngine : IEngine
{
    public void ReleaseEngine() => Console.WriteLine("japanese engine");
}

class AmericanEngine : IEngine
{
    public void ReleaseEngine() => Console.WriteLine("american engine");
}

public interface ICar
{
    void CreateCar(IEngine engine);
}

class JapaneseCar : ICar
{
    public void CreateCar(IEngine engine)
    {
        Console.WriteLine("Japanese car was created: ");
        engine.ReleaseEngine();
    }
}

class AmericanCar : ICar
{
    public void CreateCar(IEngine engine)
    {
        Console.WriteLine("Created american car: ");
        engine.ReleaseEngine();
    }    
}

interface IFactory
{
    IEngine CreateEngine();
    ICar CreateCar();
}

public class JapaneseFactory : IFactory
{
    public IEngine CreateEngine() => new JapaneseEngine();
    public ICar CreateCar() => new JapaneseCar();
}

public class AmericanFactory : IFactory
{
    public IEngine CreateEngine() => new AmericanEngine();
    public ICar CreateCar() => new AmericanCar();
}