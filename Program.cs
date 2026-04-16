using System;

Console.WriteLine("=== Перечисление BookGenre ===\n");
foreach (BookGenre genre in Enum.GetValues<BookGenre>())
{
    Console.WriteLine($"{genre}");
}

Console.WriteLine("\n=== Создание библиотеки ===\n");
Library library = new Library();

library.Add(new Book("Война и мир", "Л. Толстой", 1869, 1225, BookGenre.Novel));
library.Add(new Book("Мастер и Маргарита", "М. Булгаков", 1967, 480, BookGenre.Novel));
library.Add(new Book("1984", "Дж. Оруэлл", 1949, 328, BookGenre.SciFi));
library.Add(new Magazine("Наука и жизнь", 2024, 12, "Наука-пресс"));
library.Add(new Magazine("Вокруг света", 2023, 5, "Издательский дом"));

Console.WriteLine("Все издания:\n");
library.PrintAll();

Console.WriteLine("\n=== Поиск 'мир' (только по названию) ===\n");
var byTitle = library.Search("мир", SearchOptions.ByTitle);
foreach (var item in byTitle)
{
    Console.WriteLine(item.GetInfo());
}

Console.WriteLine("\n=== Поиск 'Толстой' (только по автору) ===\n");
var byAuthor = library.Search("Толстой", SearchOptions.ByAuthor);
foreach (var item in byAuthor)
{
    Console.WriteLine(item.GetInfo());
}

Console.WriteLine("\n=== Поиск 'Наука' (только по издательству) ===\n");
var byPublisher = library.Search("Наука", SearchOptions.ByPublisher);
foreach (var item in byPublisher)
{
    Console.WriteLine(item.GetInfo());
}

Console.WriteLine("\n=== Поиск 'мир' (по всем полям) ===\n");
var allFields = library.Search("мир", SearchOptions.All);
foreach (var item in allFields)
{
    Console.WriteLine(item.GetInfo());
}

Console.WriteLine($"\n=== Статистика ===\n");
Console.WriteLine($"Всего изданий: {LibraryItem.TotalItems}");
