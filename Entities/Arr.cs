namespace _14._12.Entities;

public class Arr
{
    public delegate bool NumberPredicate(int number);
    public static int[] GetEvenNumbers(int[] numbers)
    {
        return FilterNumbers(numbers, IsEven);
    }

    public static int[] GetOddNumbers(int[] numbers)
    {
        return FilterNumbers(numbers, IsOdd);
    }

    public static int[] GetPrimeNumbers(int[] numbers)
    {
        return FilterNumbers(numbers, IsPrime);
    }

    public static int[] GetFibonacciNumbers(int[] numbers)
    {
        return FilterNumbers(numbers, IsFibonacci);
    }

    private static int[] FilterNumbers(int[] numbers, NumberPredicate predicate) 
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (predicate(number))
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        foreach (int number in numbers)
        {
            if (predicate(number))
            {
                result[index++] = number;
            }
        }

        return result;
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    private static bool IsFibonacci(int number)
    {
        if (number < 0) return false;
        int a = 0;
        int b = 1;
        while (a < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == number;
    }
}
    
