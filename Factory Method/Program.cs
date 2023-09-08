Publisher publisher = new KSDPublisher("KSD Publisher");
var book = publisher.Publish();
Console.WriteLine($"Book: {book.Name}");


publisher = new BukvaPublisher("Bukva Publisher");
book = publisher.Publish();
Console.WriteLine($"Book: {book.Name}");
Console.ReadLine();




abstract class Book                             // BASIC class that FACTORY is creating right now
{
    public string Name { get; set; }

    public Book(string name)
    {
        Name = name;
    }
}

class KSDBook : Book                            // The first class which will be created by the FACTORY
{
    public KSDBook(string name) : base(name){}
}

class BukvaBook : Book                         // The first class which will be created by the FACTORY
{ 
    public BukvaBook(string name) : base(name){}
}

abstract class Publisher                              
{
    public string Name { get; set; }

    public Publisher(string name)
    {
        Name = name;
    }

    public abstract Book Publish();            // The main FACTORY CLASS for creating different object using only this class
}

class KSDPublisher : Publisher
{
    public KSDPublisher(string name) : base(name){}
    
    public override Book Publish()              // Overrided main method for creating the factory by the first class
    {
        Console.WriteLine($"Publisher: {Name} created the book");
        return new KSDBook("KSD Book");
    }
}

class BukvaPublisher : Publisher
{
    public BukvaPublisher(string name) : base(name){}
    
    public override Book Publish()             // Overrided main method for creating the factory by the second class
    {
        Console.WriteLine($"Publisher: {Name} created the book");
        return new BukvaBook("Bukva Book");
    }
}