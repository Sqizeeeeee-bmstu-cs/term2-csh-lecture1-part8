

static class LibraryUtils
{
    public static readonly DateTime StartupTime = DateTime.Now;
    public const string LibraryName = "Городская библиотека";

    public static void PrintSeparator(char symbol = '-', int count = 40)
    {
        Console.WriteLine(new string(symbol, count));
    }

    public static string FormatBookLists(Book[] books)
    {
        string res = "";
        int counter = 1;

        foreach (var book in books)
        {
            string s = $"{counter}. {book.ShortDescription}";
            res += $"{s} \n";
            counter++;
        }
        return res;
    }

    public static Book FindOldest(Book[] books)
    {
        if (books.Length == 0)
        {
            return null;
        }

        Book res = books[0];
        foreach (var book in books)
        {
            if (res.Year > book.Year)
            {
                res = book;
            }
        }
        return res;
    }

}


