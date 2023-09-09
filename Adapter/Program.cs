var human = new Human();
var auto = new Auto();
human.Travel(auto);
var plane = new Plane();
human.Travel(new PlaneToDriver(plane));

public class Human
{
    public void Travel(IDriver driver)
    {
        driver.Drive();
    }
}
public interface IDriver
{
    void Drive();
}
class Auto : IDriver
{
    public void Drive()
    {
        Console.WriteLine("Auto move to the destination");
    }
}
class Driver
{
    public void Travel(IDriver transport)
    {
        transport.Drive();
    }
}

interface IFlight
{
    void Fly();
}

class Plane : IFlight
{
    public void Fly()
    {
        Console.WriteLine("Plane flies to the destination");
    }
}

class PlaneToDriver : IDriver
{
    private Plane plane;

    public PlaneToDriver(Plane plane)
    {
        this.plane = plane;
    }

    public void Drive()
    {
        plane.Fly();
    }
}