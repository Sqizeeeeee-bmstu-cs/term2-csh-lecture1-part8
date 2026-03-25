
Book book1 = new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") { Genre = "Роман" };
Book book2 = new Book("Мастер и Маргарита", "М. Булгаков", 2026, 0, "Роман") { Genre = "Роман" };
Book book3 = new Book() { Genre = "" };

Console.WriteLine("=== Проверка конструкторов и свойств ===\n");

Console.WriteLine($"book1: Title={book1.Title}, Author={book1.Author}, Year={book1.Year}, PageCount={book1.PageCount}, Genre={book1.Genre}");
Console.WriteLine($"book2: Title={book2.Title}, Author={book2.Author}, Year={book2.Year}, PageCount={book2.PageCount}, Genre={book2.Genre}");
Console.WriteLine($"book3: Title='{book3.Title}', Author='{book3.Author}', Year={book3.Year}, PageCount={book3.PageCount}, Genre='{book3.Genre}'");

Console.WriteLine("\n=== Проверка вычисляемых свойств ===\n");
Console.WriteLine($"Возраст книги 'Война и мир': {book1.AgeInYears} лет");
Console.WriteLine($"Краткое описание: {book1.ShortDescription}");
Console.WriteLine($"Возраст книги 'Мастер и Маргарита': {book2.AgeInYears} лет");
Console.WriteLine($"Краткое описание: {book2.ShortDescription}");

Console.WriteLine("\n=== Проверка методов ===\n");
Console.WriteLine("GetInfo():");
Console.WriteLine(book1.GetInfo());
Console.WriteLine("\nGetInfo(false):");
Console.WriteLine(book1.GetInfo(false));
Console.WriteLine("\nGetFormattedInfo('short'):");
Console.WriteLine(book1.GetFormattedInfo("short"));
Console.WriteLine("\nGetFormattedInfo('full'):");
Console.WriteLine(book1.GetFormattedInfo("full"));
Console.WriteLine("\nGetFormattedInfo() (по умолчанию):");
Console.WriteLine(book1.GetFormattedInfo());

Console.WriteLine("\n=== Проверка IsOlderThan() ===\n");
Console.WriteLine($"'{book1.Title}' старше 50 лет? {book1.IsOlderThan()}");
Console.WriteLine($"'{book1.Title}' старше 150 лет? {book1.IsOlderThan(150)}");
Console.WriteLine($"'{book2.Title}' старше 1 года? {book2.IsOlderThan(1)}");

Console.WriteLine("\n=== Проверка валидации Year ===\n");
try
{
    Book invalidBook = new Book("Неверная", "Книга", 1400, 100, "") {Genre = "Test"};
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка при создании книги с неверным годом: {ex.Message}");
}

try
{
    Book futureBook = new Book("Книга будущего", "Автор", 2030, 100, "Фантастика") {Genre = "Test"};
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка при создании книги с годом из будущего: {ex.Message}");
}

Console.WriteLine("\n=== Проверка всех книг в цикле ===\n");
Book[] books = { book1, book2, book3 };
foreach (var book in books)
{
    Console.WriteLine(book.ShortDescription);
}

Console.WriteLine("\n=== Проверка финализатора ===\n");

static void CreateBooksForFinalizer()
{
    Book tempBook1 = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 672, "Роман") { Genre = "Роман" };
    Book tempBook2 = new Book("Евгений Онегин", "А. Пушкин", 1833, 384, "Роман в стихах") { Genre = "Роман в стихах" };
    Book tempBook3 = new Book("Мертвые души", "Н. Гоголь", 1842, 352, "Поэма") { Genre = "Поэма" };
    
    Console.WriteLine("Временные книги созданы внутри метода CreateBooksForFinalizer()");
}

CreateBooksForFinalizer();

Console.WriteLine("После вызова CreateBooksForFinalizer()");

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("Сборка мусора выполнена");
