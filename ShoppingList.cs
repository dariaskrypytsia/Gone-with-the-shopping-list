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

    if (int.TryParse(input, out int index))
{
    if (index > names.Count || index < 1)
    {
        // number doesnt exist, dont crash
        Console.WriteLine($"There's no item at spot {index}");
    }
    else
    {
        index--; // switch from human numbering to real index
        string removedName = names[index];
        names.RemoveAt(index);
        prices.RemoveAt(index);
        Console.WriteLine($"{removedName} removed from the list!");
    }
}
else
{
    // adding item stays here
    
}
}