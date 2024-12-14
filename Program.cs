using System.Text;
using _14._12.Entities;

namespace _14._12;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;  
        Console.OutputEncoding = Encoding.Unicode;

        CreditCard card = new CreditCard
        (
            12345678, 
            "John Doe", 
            "01.01.2023", 
            1234, 
            10000, 
            100
        );
        Console.WriteLine(card.ToString());
        Console.WriteLine("--------------------------");
        
        card.AddBalance(200);
        Console.WriteLine(card.ToString());
        Console.WriteLine("--------------------------");
        
        card.RemoveBalance(50);
        Console.WriteLine(card.ToString());
        Console.WriteLine("--------------------------");
        
        card.UseCredit(3000);
        Console.WriteLine(card.ToString());
        Console.WriteLine("--------------------------");

        //hz
        card.WillExceedLimit(1000);
        Console.WriteLine(card.ToString());
        Console.WriteLine("--------------------------");
        //
        
        card.ChangePin(4321);
        Console.WriteLine(card.ToString());
        Console.WriteLine("--------------------------");
    }
}