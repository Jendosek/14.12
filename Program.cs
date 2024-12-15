using System.Text;
using _14._12.Entities;

namespace _14._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;  
        Console.OutputEncoding = Encoding.Unicode;
        
        Calc calc = new Calc();
        Calc.Operation operation;
        
        operation = calc.Sum;
        Console.WriteLine(operation(10, 5));
        
        operation = calc.Sub;
        Console.WriteLine(operation(10, 5));
        
        operation = calc.Mul;
        Console.WriteLine(operation(10, 5));

    }
}