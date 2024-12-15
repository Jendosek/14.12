namespace _14._12.Entities;

public class Calc
{
    public delegate int Operation(int a, int b);

    public int Sum(int a, int b)
    {
        return a + b;
    }
    
    public int Sub(int a, int b)
    {
        return a - b;
    }
    
    public int Mul(int a, int b)
    {
        return a * b;
    }
}