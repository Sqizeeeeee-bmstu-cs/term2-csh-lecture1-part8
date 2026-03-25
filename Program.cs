
Book book1 = new Book("Война и мир", "Л. Толстой", 1869, 1225);
Book book2 = new Book("Мастер и Маргарита", "М. Булгаков");
Book book3 = new Book();

Console.WriteLine("=== Проверка метода GetInfo() ===\n");
Console.WriteLine(book1.GetInfo());
Console.WriteLine();
Console.WriteLine(book2.GetInfo());
Console.WriteLine();
Console.WriteLine(book3.GetInfo());

Console.WriteLine("\n=== Проверка перегрузки GetInfo(bool showPages) ===\n");
Console.WriteLine("С количеством страниц:");
Console.WriteLine(book1.GetInfo(true));
Console.WriteLine("\nБез количества страниц:");
Console.WriteLine(book1.GetInfo(false));

Console.WriteLine("\n=== Проверка метода IsOlderThan() ===\n");
Console.WriteLine($"Книга '{book1.GetInfo().Split(',')[0].Substring(6)}' старше 50 лет? {book1.IsOlderThan()}");
Console.WriteLine($"Книга '{book1.GetInfo().Split(',')[0].Substring(6)}' старше 150 лет? {book1.IsOlderThan(150)}");
Console.WriteLine($"Книга '{book2.GetInfo().Split(',')[0].Substring(6)}' старше 1 года? {book2.IsOlderThan(1)}");

Console.WriteLine("\n=== Проверка метода GetFormattedInfo() ===\n");
Console.WriteLine("Краткий формат (short):");
Console.WriteLine(book1.GetFormattedInfo("short"));
Console.WriteLine("\nПолный формат (full):");
Console.WriteLine(book1.GetFormattedInfo("full"));
Console.WriteLine("\nФормат по умолчанию (без параметра):");
Console.WriteLine(book1.GetFormattedInfo());

Console.WriteLine("\n=== Проверка всех книг в цикле ===\n");
Book[] books = { book1, book2, book3 };
foreach (var book in books)
{
    Console.WriteLine(book.GetFormattedInfo("short"));
}
