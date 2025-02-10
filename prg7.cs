using System;

class Program
{
    static void Main(string[] args)
    {
        // Input number
        double number = 5.75;

        // Variables to hold the integer and fractional parts
        int integerPart;
        double fractionalPart;

        // Call the method to get the integer and fractional parts
        GetIntegerAndFractionalParts(number, out integerPart, out fractionalPart);

        // Display the results
        Console.WriteLine("Original number: " + number);
        Console.WriteLine("Integer part: " + integerPart);
        Console.WriteLine("Fractional part: " + fractionalPart);
    }

    // Method to get the integer and fractional parts using out parameters
    static void GetIntegerAndFractionalParts(double num, out int intPart, out double fracPart)
    {
        intPart = (int)num; // Get the integer part
        fracPart = num - intPart; // Calculate the fractional part
    }
}
