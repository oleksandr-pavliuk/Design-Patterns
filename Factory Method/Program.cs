Publisher publisher = new KSDPublisher("KSD Publisher");
var book = publisher.Publish();
Console.WriteLine($"Book: {book.Name}");
publisher = new BukvaPublisher("Bukva Publisher");
book = publisher.Publish();
Console.WriteLine($"Book: {book.Name}");
Console.ReadLine();




abstract class Book
{
    public string Name { get; set; }

    public Book(string name)
    {
        Name = name;
    }
}

class KSDBook : Book
{
    public KSDBook(string name) : base(name){}
}

class BukvaBook : Book
{
    public BukvaBook(string name) : base(name){}
}

abstract class Publisher                               // The main FACTORY METHOD for creating different object using only this class
{
    public string Name { get; set; }

    public Publisher(string name)
    {
        Name = name;
    }

    public abstract Book Publish();
}

class KSDPublisher : Publisher
{
    public KSDPublisher(string name) : base(name){}
    
    public override Book Publish()
    {
        Console.WriteLine($"Publisher: {Name} created the book");
        return new KSDBook("KSD Book");
    }
}

class BukvaPublisher : Publisher
{
    public BukvaPublisher(string name) : base(name){}
    
    public override Book Publish()
    {
        Console.WriteLine($"Publisher: {Name} created the book");
        return new BukvaBook("Bukva Book");
    }
}