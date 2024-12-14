namespace _14._12.Entities;

public class Timer
{
    // Method to display the current time
    public static void DisplayCurrentTime()
    {
        Console.WriteLine("Current Time: " + DateTime.Now.ToString("HH:mm:ss"));
    }

    // Method to display the current date
    public static void DisplayCurrentDate()
    {
        Console.WriteLine("Current Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
    }

    // Method to display the current day of the week
    public static void DisplayCurrentDayOfWeek()
    {
        Console.WriteLine("Current Day of the Week: " + DateTime.Now.DayOfWeek);
    }

    // Method to calculate the area of a triangle
    public static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    // Method to calculate the area of a rectangle
    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
}
    
