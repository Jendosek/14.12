using System.Text;
using _14._12.Entities;

namespace _14._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;  
        Console.OutputEncoding = Encoding.Unicode;
        
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] evenNumbers = Arr.GetEvenNumbers(numbers);
        int[] oddNumbers = Arr.GetOddNumbers(numbers);
        int[] primeNumbers = Arr.GetPrimeNumbers(numbers);
        int[] fibonacciNumbers = Arr.GetFibonacciNumbers(numbers);
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        Console.WriteLine("Prime numbers: " + string.Join(", ", primeNumbers));
        Console.WriteLine("Fibonacci numbers: " + string.Join(", ", fibonacciNumbers));
        
    }
}