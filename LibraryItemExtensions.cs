
public static class LibraryItemExtensions
{
    public static bool IsNew(this LibraryItem item, int year = 5)
    {
        if (DateTime.Now.Year - item.Year < year)
        {
            return true;
        }
        return false;
    }

    public static string ToCsvLine(this LibraryItem item)
    {
        if (item is Book book)
        {
            return $"{item.GetType().Name};{book.Title};{book.Year};{book.Author}, {book.PageCount} стр.";
        }
        else if (item is Magazine magazine)
        {
            return $"{item.GetType().Name};{magazine.Title};{magazine.Year};{magazine.Publisher}, №{magazine.IssueNumber}";
        }
        else
        {
            throw new InvalidBookDataException("don't know the item");
        }
    }
    public static void PrintCard(this LibraryItem item)
    {
        string content = item.GetCardInfo();
        int width = content.Length + 2;
        
        Console.WriteLine($"╔{new string('═', width)}╗");
        Console.WriteLine($"║ {content} ║");
        Console.WriteLine($"╚{new string('═', width)}╝");
    }

}
