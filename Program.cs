using System;

LibraryItem[] items = 
{
    new Book("Война и мир", "Л. Толстой", 1869, 1225, "Роман") {Genre = "Роман"},
    new Magazine("Наука и жизнь", 2024, 12, "Наука-пресс"),
    new Book("Мастер и Маргарита", "М. Булгаков", 1967, 480, "Роман") {Genre = "Роман"},
    new Magazine("Вокруг света", 2023, 5, "Издательский дом")
};

Console.WriteLine("=== Демонстрация полиморфизма ===\n");

foreach (var item in items)
{
    Console.WriteLine($"--- {item.GetType().Name} ---");
    Console.WriteLine($"GetInfo(): {item.GetInfo()}");
    Console.WriteLine($"GetCardInfo(): {item.GetCardInfo()}");
    Console.WriteLine($"Description: {item.Description}");
    Console.WriteLine();
}
