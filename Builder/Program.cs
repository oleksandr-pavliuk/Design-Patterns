Creator creator = new Creator();
Builder builder = new ApplePhoneBuilder();
var phone = creator.Create(builder);
Console.WriteLine(phone.ToString());

builder = new SamsungPhoneBuilder();
phone = creator.Create(builder);
Console.WriteLine(phone.ToString());


class Creator                                               // creator for the phone creation
{
    public Phone Create(Builder builder)
    {
        builder.CreatePhone();
        builder.SetName();
        builder.SetCamera();
        builder.SetOS();
        builder.SetMaterials();
        return builder.Phone;
    }
}


public class Camera
{
    public int Pixels { get; set; }
}

public class OS
{
    public string Name { get; set; }
}

public class Materials
{
    public string Name { get; set; }
}

public class Phone                                 // parent class for objects which will be created
{
    public string Name { get; set; }
    public Camera Camera { get; set; }
    public OS OS { get; set; }
    public Materials Materials { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}     Materials: {Materials.Name}     OS: {OS.Name}      Camera: {Camera.Pixels}";
    }
}

public abstract class Builder                       // parent of the different builders
{
    public Phone Phone { get; set; }

    public void CreatePhone()
    {
        Phone = new Phone();
    }

    public abstract void SetName();
    public abstract void SetCamera();
    public abstract void SetOS();
    public abstract void SetMaterials();
}

public class ApplePhoneBuilder : Builder               // apple phone builder with create the Iphone using different components
{
    public override void SetName()
    {
        Phone.Name = "IPhone 14 Max";
    }
    public override void SetCamera()
    {
        Phone.Camera = new Camera() {Pixels = 20};
    }

    public override void SetOS()
    {
        Phone.OS = new OS() {Name = "iOS"};
    }

    public override void SetMaterials()
    {
        Phone.Materials = new Materials() {Name = "metal"};
    }
}

public class SamsungPhoneBuilder : Builder                // samsung phone builder with create the Iphone using different components
{
    public override void SetName()
    {
        Phone.Name = "Samsung S21";
    }
    public override void SetCamera()
    {
        Phone.Camera = new Camera() {Pixels = 21};
    }

    public override void SetOS()
    {
        Phone.OS = new OS() {Name = "Android"};
    }

    public override void SetMaterials()
    {
        Phone.Materials = new Materials() {Name = "plastic"};
    }
}