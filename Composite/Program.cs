Component fileSystem = new Directory("File System");

Component diskC = new Directory("Disk C");

Component pngFile = new File("12345.png");
Component docxFile = new File("Document.docx");

diskC.Add(pngFile);
diskC.Add(docxFile);

fileSystem.Add(diskC);
fileSystem.Print();

Console.WriteLine();

diskC.Remove(pngFile);

Component docsFolder = new Directory("My Documents");

Component txtFile = new File("readme.txt");
Component csFile = new File("Program.cs");
docsFolder.Add(txtFile);
docsFolder.Add(csFile);
diskC.Add(docsFolder);
         
fileSystem.Print();
 
Console.Read();


public abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public virtual void Add(Component component){}
    public virtual void Remove(Component component){}
    public virtual void Print()
    {
        Console.WriteLine(name);
    }
}

public class Directory : Component
{
    private List<Component> components = new List<Component>();
    public Directory(string name) : base(name) {}

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }

    public override void Print()
    {
        Console.WriteLine("Main directory: " + name);
        Console.WriteLine("Sub directories:");
        foreach(var component in components)
        {
            component.Print();
        }
    }
}
class File : Component
{
    public File(string name)
        : base(name)
    {}
}