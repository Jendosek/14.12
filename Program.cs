using System.Text;
using _14._12.Entities;
using Timer = _14._12.Entities.Timer;

namespace _14._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;  
        Console.OutputEncoding = Encoding.Unicode;
        
        Timer.DisplayCurrentTime();
        Timer.DisplayCurrentDate();
        Timer.DisplayCurrentDayOfWeek();
        Console.WriteLine(Timer.CalculateTriangleArea(5, 10));
        Console.WriteLine(Timer.CalculateRectangleArea(5, 10));
        
        
    }
}