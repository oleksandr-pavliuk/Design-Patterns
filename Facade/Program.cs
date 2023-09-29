TextEditor textEditor = new TextEditor();
Compiler compiler = new Compiler();
CLR clr = new CLR();

VisualStudioFacade vs = new VisualStudioFacade(textEditor, compiler, clr);
Developer developer = new Developer();
developer.CreateApplication(vs);

public class Developer
{
    public void CreateApplication(VisualStudioFacade vs)
    {
        vs.Start();
        vs.Finish();
    }
}
public class TextEditor
{
    public void WriteCode() => Console.WriteLine("Code writing . . .");
    public void Save() => Console.WriteLine("File saving . . . ");
}

public class Compiler
{
    public void Compile() => Console.WriteLine("Compiling the code . . .");
}

public class CLR
{
    public void Execute() => Console.WriteLine("Executing the code . . .");
    public void Finish() => Console.WriteLine("Finishing the ccode . . . ");
}

public class VisualStudioFacade
{
    private TextEditor _textEditor;
    private Compiler _compiler;
    private CLR _clr;

    public VisualStudioFacade(TextEditor textEditor, Compiler compiler, CLR clr)
    {
        _textEditor = textEditor;
        _compiler = compiler;
        _clr = clr;
    }

    public void Start()
    {
        _textEditor.WriteCode();
        _textEditor.Save();
        _compiler.Compile();
        _clr.Execute();
    }

    public void Finish()
    {
        _clr.Finish();
    }
}