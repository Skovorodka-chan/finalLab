using System;

public class Year
{
    public static void Main()
    {
        Console.WriteLine("Введите год YYYY");
        while (true)
        {
            if (YearV(Convert.ToInt32(Console.ReadLine())))
            {
                //YearV(yearSt);
                Console.WriteLine("Високостный год");
            }
            else
            {
                Console.WriteLine("Невисокостный год");
            }
        }
    }
    public static bool YearV(int year)
    {
        //int year = Convert.ToInt32(yearSt);
        return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
    }
}


