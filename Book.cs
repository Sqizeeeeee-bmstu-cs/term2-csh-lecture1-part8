
using System.Runtime.CompilerServices;

public class Book
{
    public string Title { get; init; }
    public string Author { get; init; }
    private int _year;
    public int Year
    {
        get { return _year; }
        set
        {
            if (value > DateTime.Now.Year || value < 1450)
            {
                throw new ArgumentException("Год должен быть от 1450 до текущего");
            }
            _year = value;
        }
    }
    
    public int PageCount {get; set; }

    public required string Genre {get; init; }

    public int AgeInYears => DateTime.Now.Year - Year;

    public string ShortDescription 
    {
        get { return $"{Title} - {Author} ({Year})"; }
    }

    public Book(string title, string author, int year, int pageCount, string genre)
    {
        Title = title;
        Author = author;
        Year = year;
        PageCount = pageCount;
        Genre = genre;
    }

    public Book(string title, string author, string genre = "") : this (title, author, 2026, 0, genre) {}

    public Book() : this ("", "", "") {}

    public string GetInfo()
    {
        return $"book: {Title}, author: {Author}, year: {Year}, pages: {PageCount}";
    }

    public string GetInfo(bool showPages)
    {
        if (showPages)
        {
            return GetInfo();
        }
        else
        {
            return $"book: {Title}, author: {Author}, year: {Year}";
        }
    }

    public bool IsOlderThan(int years = 50) => AgeInYears > years;

    public string GetFormattedInfo(string format = "short")
    {

        if (format == "short")
        {
            return ShortDescription;
        }
        return GetInfo();
    }

    ~Book()
    {
        Console.WriteLine($"Финализатор: книга «{Title}» удалена из памяти");
    }
}