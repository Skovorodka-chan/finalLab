while (true)
{
    var arrowsKey = Console.ReadKey();
    switch (arrowsKey.Key)
    {
        case ConsoleKey.UpArrow:
            Console.Clear();
            Console.Write("↑");
            break;
        
        case ConsoleKey.DownArrow:
            Console.Clear();
            Console.WriteLine("↓");
            break;

        case ConsoleKey.LeftArrow:
            Console.Clear();
            Console.WriteLine("←");
            break;

        case ConsoleKey.RightArrow:
            Console.Clear();
            Console.WriteLine("→");
            break;
    }
}