List<string> names = [];
List<int> prices = [];

while (true)
{
    // just print the list here for now
    Console.WriteLine("\nNumber - Item - Price");
    Console.WriteLine("--------------------------");
    int total = 0;
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
        total = total + prices[i];
    }
    Console.WriteLine($"Total: {total} kr");

    Console.WriteLine("\nType an item name to add, or a number to remove: ");
    string? input = Console.ReadLine().Trim();

    // adding and removing comes later
}