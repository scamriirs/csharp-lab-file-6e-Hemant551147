using System;

// Base class
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayPersonDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// Derived class from Person
public class Employee : Person
{
    public string EmployeeId { get; set; }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeId);
    }
}

// Derived class from Employee
public class Programmer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public void DisplayProgrammerDetails()
    {
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the Programmer class
        Programmer programmer = new Programmer();

        // Assigning values to the properties
        programmer.Name = "John Doe";
        programmer.Age = 30;
        programmer.EmployeeId = "E12345";
        programmer.ProgrammingLanguage = "C#";

        // Displaying the details
        programmer.DisplayPersonDetails();
        programmer.DisplayEmployeeDetails();
        programmer.DisplayProgrammerDetails();
    }
}
