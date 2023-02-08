using lab2;

Console.WriteLine("Введите число от 0 по 10000 включительно");

while (true)
{
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if ((number >= 0) && (number <= 10000))
    {
        Console.WriteLine($"Число {num} {(MathN.PrimeN(number) ? "простое!" : "не является простым")}");
        break;
    }
    Console.WriteLine("Не то число! Выбири ещё раз!");
}