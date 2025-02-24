using System;

namespace OfferLetterAutomation
{
    // Abstract base class
    public abstract class Person
    {
        // Fixed properties for the company
        public static string CompanyName = "Tech Solutions Inc.";
        public static string CompanyAddress = "123 Tech Park, Silicon Valley, CA";
        public static string CompanyBranding = "Empowering Innovation";
        public static string CompanyDisclaimer = "This offer is confidential and for internal use only.";

        // Abstract method for generating the offer letter
        public abstract string GenerateOfferLetter();
    }

    // Employee class inherits from Person
    public class Employee : Person
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string job, string designation, double salary)
        {
            Name = name;
            Job = job;
            Designation = designation;
            Salary = salary;
        }

        // Implementing the abstract method to generate offer letter
        public override string GenerateOfferLetter()
        {
            return $@"
-------------------------------------------
{CompanyName}
{CompanyAddress}
{CompanyBranding}
-------------------------------------------

OFFER LETTER

Dear {Name},

We are pleased to offer you the position of {Designation} at {CompanyName}.
You will be working in the {Job} department, and your annual salary will be ${Salary}.

This offer is contingent upon the successful completion of background checks and other requirements.

We look forward to having you on our team!

Best regards,
Human Resources
{CompanyName}

-------------------------------------------
{CompanyDisclaimer}
-------------------------------------------
";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example: Create an employee and generate an offer letter
            Employee employee = new Employee("John Doe", "Engineering", "Software Engineer", 90000);
            string offerLetter = employee.GenerateOfferLetter();

            Console.WriteLine(offerLetter);
        }
    }
}
