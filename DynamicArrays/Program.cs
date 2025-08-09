





/*#####################################################################################################################*/
// O(n) Complexitiy
static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
        Console.WriteLine(item);
}

static void PrintTitle(string title)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\n=== {title} ===");
    Console.ResetColor();
}

static void PrintError(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

