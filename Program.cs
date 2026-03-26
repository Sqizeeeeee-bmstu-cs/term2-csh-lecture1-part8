// Вывод информации о библиотеке
Console.WriteLine($"Библиотека: {LibraryUtils.LibraryName}");
Console.WriteLine($"Время запуска: {LibraryUtils.StartupTime}");
LibraryUtils.PrintSeparator();

// Создание книг
Book book1 = new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") {Genre = "Роман"};
Book book2 = new Book("Мастер и Маргарита", "М. Булгаков", 1967, 480, "Роман") {Genre = "Роман"};
Book book3 = new Book("1984", "Дж. Оруэлл", 1949, 328, "Антиутопия") {Genre = "Антиутопия"};

Book[] books = { book1, book2, book3 };

// Статистика
Console.WriteLine("\n=== Статистика ===\n");
Book.PrintStatistics();

// Тестирование LibraryUtils
Console.WriteLine("\n=== Список книг ===\n");
Console.WriteLine(LibraryUtils.FormatBookLists(books));

LibraryUtils.PrintSeparator();

Console.WriteLine("\n=== Самая старая книга ===\n");
Book oldest = LibraryUtils.FindOldest(books);
Console.WriteLine(oldest.ShortDescription);

// Тестирование финализатора
Console.WriteLine("\n=== Финализатор ===\n");
static void CreateBooks()
{
    Book temp1 = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 672, "Роман") {Genre = "Роман"};
    Book temp2 = new Book("Евгений Онегин", "А. Пушкин", 1833, 384, "Роман") {Genre = "Роман"};
    Console.WriteLine("Временные книги созданы");
}

CreateBooks();
GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("\n=== Итоговая статистика ===\n");
Book.PrintStatistics();
