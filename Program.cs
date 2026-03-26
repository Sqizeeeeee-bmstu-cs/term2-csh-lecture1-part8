using System;

// Создание массива LibraryItem
LibraryItem[] items = 
{
    new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") {Genre = "Роман"},
    new Magazine("Наука и жизнь", 2024, 12, "Наука-пресс"),
    new Book("Мастер и Маргарита", "М. Булгаков", 1967, 480, "Роман") {Genre = "Роман"},
    new Magazine("Вокруг света", 2023, 5, "Издательский дом")
};

Console.WriteLine("=== Список всех изданий ===\n");

foreach (var item in items)
{
    Console.WriteLine(item.GetInfo());
    
    // Проверка типа с помощью is
    if (item is Book)
    {
        // Приведение с помощью as
        Book book = item as Book;
        Console.WriteLine($"  -> Книга, автор: {book?.Author}");
    }
    else if (item is Magazine)
    {
        Magazine magazine = item as Magazine;
        Console.WriteLine($"  -> Журнал, выпуск: {magazine?.IssueNumber}");
    }
}

Console.WriteLine($"\n=== Статистика ===\n");
Console.WriteLine($"Всего изданий: {LibraryItem.TotalItems}");
