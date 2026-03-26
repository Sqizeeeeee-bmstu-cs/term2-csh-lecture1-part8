using System;

LibraryItem[] items = 
{
    new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") {Genre = "Роман"},
    new Magazine("Наука и жизнь", 2024, 12, "Наука-пресс"),
    new Book("Мастер и Маргарита", "М. Булгаков", 1967, 480, "Роман") {Genre = "Роман"},
    new Magazine("Вокруг света", 2023, 5, "Издательский дом")
};

Console.WriteLine("=== Проверка методов расширения ===\n");

foreach (var item in items)
{
    Console.WriteLine($"--- {item.GetType().Name} ---");
    Console.WriteLine($"Название: {item.Title}");
    Console.WriteLine($"Новое (5 лет): {item.IsNew()}");
    Console.WriteLine($"Новое (10 лет): {item.IsNew(10)}");
    Console.WriteLine($"CSV: {item.ToCsvLine()}");
    Console.WriteLine("Каталожная карточка:");
    item.PrintCard();
    Console.WriteLine();
}
