using System;

Library library = new Library();

// Добавление книг и журналов
library.Add(new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") {Genre = "Роман"});
library.Add(new Magazine("Наука и жизнь", 2024, 12, "Наука-пресс"));
library.Add(new Book("Мастер и Маргарита", "М. Булгаков", 1967, 480, "Роман") {Genre = "Роман"});
library.Add(new Magazine("Вокруг света", 2023, 5, "Издательский дом"));
library.Add(new Book("1984", "Дж. Оруэлл", 1949, 328, "Антиутопия") {Genre = "Роман"});

Console.WriteLine("=== Все издания ===\n");
library.PrintAll();

Console.WriteLine("\n=== Поиск по названию 'мир' ===\n");
var found = library.FindByTitle("мир");
foreach (var item in found)
{
    Console.WriteLine(item.GetInfo());
}

Console.WriteLine("\n=== Только книги ===\n");
var books = library.FindBooks();
foreach (var book in books)
{
    Console.WriteLine(book.GetInfo());
}
Console.WriteLine($"Всего книг: {books.Count}");

Console.WriteLine("\n=== Только журналы ===\n");
var magazines = library.FindMagazines();
foreach (var magazine in magazines)
{
    Console.WriteLine(magazine.GetInfo());
}
Console.WriteLine($"Всего журналов: {magazines.Count}");
