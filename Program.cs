using System;

Library library = new Library();

// Добавляем несколько книг вручную
library.Add(new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") {Genre = "Роман"});
library.Add(new Magazine("Наука и жизнь", 2024, 12, "Наука-пресс"));

Console.WriteLine("=== Текущий каталог ===\n");
library.PrintAll();

// Добавление книги через консоль
library.AddFromConsole();

Console.WriteLine("\n=== Обновленный каталог ===\n");
library.PrintAll();

Console.WriteLine($"\nВсего изданий: {LibraryItem.TotalItems}");
