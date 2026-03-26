

public partial class Library
{
    
    public List<LibraryItem> FindByTitle(string value)
    {
        List<LibraryItem> res = new List<LibraryItem>();

        foreach(var item in _items)
        {
            if (item.Title.Contains(value))
            {
                res.Add(item);
            }
        }
        return res;
    }

    public List<Book> FindBooks()
    {
        List<Book> res = new List<Book>();

        foreach (var item in _items)
        {
            if (item is Book)
            {
                res.Add((Book)item);
            }
        }
        return res;
    }

    public List<Magazine> FindMagazines()
    {
        List<Magazine> res = new List<Magazine>();

        foreach (var item in _items)
        {
            if (item is Magazine)
            {
                res.Add((Magazine)item);
            }
        }

        return res;
    }

}
