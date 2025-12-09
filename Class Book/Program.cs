

Book book = new("PriKvadratnoyLune", "Ilyusha", 1000000);
BookGenre bookGenre = new("PriKvadratnoyLune", "Ilyusha", 1000000, "Fanfic");
BookGenrePubl bookGenrePubl = new("PriKvadratnoyLune", "Ilyusha", 1000000, "Fanfic", "YandexMusic");

Console.WriteLine("Book:");
book.Print();
Console.WriteLine("\nBookGenre:");
bookGenre.Print();
Console.WriteLine("\nBookGenrePubl:");
bookGenrePubl.Print();
Console.WriteLine("\n\nFigure:");
ProgramF.Main();


internal class Book
{
    string Name { get; set; } = "-";
    string AuthorName { get; set; } = "Noname";
    int Price { get; set; } = int.MaxValue;

    public Book(string name, string authorName, int price)
    {
        Name = name;
        AuthorName = authorName;
        Price = price;
    }

    public virtual void Print()
    {
        Console.Write($"Book: {Name}, by {AuthorName}, costs: {Price} = mnoga");
    }
}

internal class BookGenre : Book
{
    string Genre { get; set; } = "-";

    public BookGenre(string name, string authorName, int price, string genre) : base(name, authorName, price)
    {
        Genre = genre;
    }

    public override void Print()
    {
        base.Print();
        Console.Write($", genre: {Genre}");
    }
}

internal class BookGenrePubl : BookGenre
{
    string Publ { get; set; } = "Noname";

    public BookGenrePubl(string name, string authorName, int price, string genre, string publ) : base(name, authorName, price, genre)
    {
        Publ = publ;
    }

    public override void Print()
    {
        base.Print(); Console.WriteLine($", publ: {Publ}");
    }
}