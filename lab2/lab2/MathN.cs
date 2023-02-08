namespace lab2;

public static class MathN
{
    public static bool PrimeN(int number)
    {
        if (number == 0 || number == 1) 
            return false;

        if (number == 2)
            return true;

        for (int i = 2; i < number; i++)
        {
            if ( number % i == 0)
            {
                return false;
            }            
        }
        return true;
    }
}

