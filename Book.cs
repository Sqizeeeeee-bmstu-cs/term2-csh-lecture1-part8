
public class Book : LibraryItem
{
    public string Author { get; init; }
    
    private int _pageCount = 0;

    public int PageCount
    {
        get { return _pageCount; }
        set
        {
            if (value > MaxPageCount || value <= 0)
            {
                throw new ArgumentException("Превышено максимальное кол-во страниц");
            }
            _pageCount = value;
        }
    }

    public override string GetCardInfo()
    {
        return $"{Title}, {Author}, {Year}, - {PageCount}";
    }

    public required string Genre {get; init; }

    public int AgeInYears => DateTime.Now.Year - Year;

    public const int MaxPageCount = 10000;

    public string ShortDescription 
    {
        get { return $"{Title} - {Author} ({Year})"; }
    }

    public Book(string title, string author, int year, int pageCount, string genre) : base(title, year)
    {
        Author = author;
        PageCount = pageCount;
        Genre = genre;
    }

    public Book(string title, string author, string genre = "") : this (title, author, 2026, 0, genre) {}

    public Book() : this ("", "", "") {}

    public override string GetInfo()
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