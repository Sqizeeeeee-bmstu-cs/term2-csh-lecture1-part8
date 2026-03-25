

using System.IO.Pipelines;

static class LibraryUtils
{
    static public void PrintSeparator(char symbol = '-', int count = 40)
    {
        Console.WriteLine(new string(symbol, count));
    }

    static public string FormatBookLists(Book[] books)
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

}


