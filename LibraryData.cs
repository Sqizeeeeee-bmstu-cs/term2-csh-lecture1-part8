

public partial class Library
{
    
    private List<LibraryItem> _items = new List<LibraryItem>();

    public void Add(LibraryItem item)
    {
        _items.Add(item);
    }

    public void PrintAll()
    {
        foreach(var item in _items)
        {
            Console.WriteLine(item.GetInfo());
        }
    }

}
