

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

    public void AddFromConsole()
    {
        Console.WriteLine("\n=== Добавление новой книги ===\n");
        
        string title = "";
        string author = "";
        int year = 0;
        int pageCount = 0;
        string genre = "";
        
        // Ввод названия
        while (true)
        {
            try
            {
                Console.Write("Введите название книги: ");
                title = Console.ReadLine()?.Trim() ?? "";
                
                if (string.IsNullOrWhiteSpace(title))
                    throw new InvalidBookDataException("Название не может быть пустым");
                
                break;
            }
            catch (InvalidBookDataException ex) when (ex.Message.Contains("пустым"))
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Попробуйте снова.");
            }
        }
        
        // Ввод автора
        while (true)
        {
            try
            {
                Console.Write("Введите автора: ");
                author = Console.ReadLine()?.Trim() ?? "";
                
                if (string.IsNullOrWhiteSpace(author))
                    throw new InvalidBookDataException("Автор не может быть пустым");
                
                break;
            }
            catch (InvalidBookDataException ex) when (ex.Message.Contains("пустым"))
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Попробуйте снова.");
            }
        }
        
        // Ввод года
        while (true)
        {
            try
            {
                Console.Write("Введите год издания: ");
                if (!int.TryParse(Console.ReadLine(), out year))
                    throw new InvalidBookDataException("Год должен быть числом");
                
                Book temp = new Book("temp", "temp", year, 1, "temp") {Genre = "temp"};
                break;
            }
            catch (InvalidBookDataException ex) when (ex.Message.Contains("Год"))
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Попробуйте снова.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число. Попробуйте снова.");
            }
        }
        
        // Ввод количества страниц
        while (true)
        {
            try
            {
                Console.Write("Введите количество страниц: ");
                if (!int.TryParse(Console.ReadLine(), out pageCount))
                    throw new InvalidBookDataException("Количество страниц должно быть числом");
                
                Book temp = new Book("temp", "temp", 2000, pageCount, "temp") {Genre = "temp"};
                break;
            }
            catch (InvalidBookDataException ex) when (ex.Message.Contains("страниц"))
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Попробуйте снова.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число. Попробуйте снова.");
            }
        }
        
        // Ввод жанра
        while (true)
        {
            try
            {
                Console.Write("Введите жанр: ");
                genre = Console.ReadLine()?.Trim() ?? "";
                
                if (string.IsNullOrWhiteSpace(genre))
                    throw new InvalidBookDataException("Жанр не может быть пустым");
                
                break;
            }
            catch (InvalidBookDataException ex) when (ex.Message.Contains("пустым"))
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Попробуйте снова.");
            }
        }
        
        // Создание и добавление книги
        try
        {
            Book book = new Book(title, author, year, pageCount, genre) {Genre = genre};
            Add(book);
            Console.WriteLine($"\n✓ Книга \"{title}\" успешно добавлена!");
        }
        catch (InvalidBookDataException ex)
        {
            Console.WriteLine($"\n❌ Ошибка при создании книги: {ex.Message}");
        }
    }

}
