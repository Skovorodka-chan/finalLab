using System;

public class Year
{
    static void Main()
    {
        Console.WriteLine("Введите год YYYY");
        string yearSt = Console.ReadLine();
        int year = Convert.ToInt32(yearSt);
 
        if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine("Високостный год");
        }
        else
        {
            Console.WriteLine("Невисокостный год");
        }
    }
}
