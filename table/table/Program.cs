using System;

public class Table 
{ 
    static void Main()
    {
        Console.WindowWidth = 100;
        Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
        Console.Write("___________________________________________________________________________________");
        Console.WriteLine();
        for (int i = 1; i < 11; i++)
        {
            Console.Write("\n" + i + "|");
            for (int j = 1; j < 11; j++)
            {
                Console.Write("\t" + i * j);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}
