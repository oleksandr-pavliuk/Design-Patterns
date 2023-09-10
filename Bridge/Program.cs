Teacher teacher = new MathTeacher(new Algebra());
teacher.DoWork();
teacher.Language = new Geometry();
teacher.DoWork();
teacher.EarnMoney();

public interface ISubject
{
    void TeachTeory();
    void MakeTest();
}

public class Algebra : ISubject
{
    public void TeachTeory()
    {
        Console.WriteLine("Teaching the ALGEBRA");
    }

    public void MakeTest()
    {
        Console.WriteLine("Make the ALGEBRA test");
    }
}

public class Geometry : ISubject
{
    public void TeachTeory()
    {
        Console.WriteLine("Teach the GEOMETRY");
    }

    public void MakeTest()
    {
        Console.WriteLine("Make the GEOMETRY test");
    }
}

public abstract class Teacher
{
    protected ISubject language;
    public ISubject Language
    {
        set { language = value; }
    }
    public Teacher (ISubject lang)
    {
        language = lang;
    }
    public virtual void DoWork()
    {
        language.TeachTeory();
        language.MakeTest();
    }
    public abstract void EarnMoney();
}

public class MathTeacher : Teacher
{
    public override void EarnMoney()
    {
        Console.WriteLine("Get the money for the lessons");
    }

    public MathTeacher(ISubject lang) : base(lang)
    {
    }
}