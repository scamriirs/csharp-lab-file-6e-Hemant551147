using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 5; // Original number
        Console.WriteLine("Original number: " + number);
        
        // Call the method to calculate the square
        int square = SquareByValue(number);
        Console.WriteLine("Square (pass by value): " + square);
        Console.WriteLine("Number after method call: " + number); // Original number remains unchanged
    }

    // Method to calculate square using pass by value
    static int SquareByValue(int num)
    {
        return num * num; // Return the square of the number
    }
}
