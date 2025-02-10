using System;

class Program
{
    static void Main()
    {
        int[] array = { 28, 31, 88, 56, 26 };
        int smallestElement = FindSmallestElement(array);
        
        Console.WriteLine("The smallest element in the array is: " + smallestElement);
    }

    static int FindSmallestElement(int[] arr)
    {
        if (arr.Length == 0) // Check if the array is empty
        {
            throw new ArgumentException("Array cannot be empty");
        }

        int smallest = arr[0]; // Assume the first element is the smallest
        foreach (int num in arr)
        {
            if (num < smallest)
            {
                smallest = num; // Update smallest if a smaller number is found
            }
        }
        return smallest;
    }
}
