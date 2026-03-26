
public abstract class LibraryItem
{
    public const int MinYear = 1450;

    public string Title { get; init;}

    public virtual string Description => GetInfo();

    private int _year;

    public int Year
    {
        get => _year;
        set => _year = (value <= DateTime.Now.Year && value >= MinYear) ? value : throw new InvalidBookDataException("Год должен быть от 1450 до текущего");
    }

    private static int _totalItems = 0;

    public static int TotalItems => _totalItems;

    public LibraryItem(string title, int year)
    {
        Title = title;
        Year = year;
        _totalItems++;
    }
    public abstract string GetCardInfo();

    public virtual string GetInfo()
    {
        return $"{Title} ({Year})";
    }
}
