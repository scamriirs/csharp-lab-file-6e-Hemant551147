using System;

class SeatBookingSystem
{
    // Declare a 2D array to represent the seating arrangement
    static string[,] seats = new string[5, 5] 
    {
        { "A1", "A2", "A3", "A4", "A5" },
        { "B1", "B2", "B3", "B4", "B5" },
        { "C1", "C2", "C3", "C4", "C5" },
        { "D1", "D2", "D3", "D4", "D5" },
        { "E1", "E2", "E3", "E4", "E5" }
    };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Seat Booking Management System");
            Console.WriteLine("1) View the seat layout");
            Console.WriteLine("2) Book a seat");
            Console.WriteLine("3) Cancel a seat");
            Console.WriteLine("4) Check availability of a seat");
            Console.WriteLine("5) Exit");
            Console.Write("Enter your choice: ");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewSeats();
                    break;
                case 2:
                    BookSeat();
                    break;
                case 3:
                    CancelSeat();
                    break;
                case 4:
                    CheckAvailability();
                    break;
                case 5:
                    Console.WriteLine("Exiting the system.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to view the seat layout
    static void ViewSeats()
    {
        Console.WriteLine("Current Seat Layout:");
        for (int i = 0; i < seats.GetLength(0); i++)
        {
            for (int j = 0; j < seats.GetLength(1); j++)
            {
                if (seats[i, j] == "X")
                    Console.Write("[X] "); // Booked seat
                else
                    Console.Write("[ ] "); // Available seat
            }
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    // Method to book a seat
    static void BookSeat()
    {
        Console.Write("Enter row (1-5): ");
        int row = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter column (1-5): ");
        int col = int.Parse(Console.ReadLine()) - 1;

        if (row < 0 || row > 4 || col < 0 || col > 4)
        {
            Console.WriteLine("Invalid seat position. Please try again.");
        }
        else if (seats[row, col] == "X")
        {
            Console.WriteLine("This seat is already booked.");
        }
        else
        {
            seats[row, col] = "X"; // Mark the seat as booked
            Console.WriteLine("Seat booked successfully.");
        }

        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    // Method to cancel a seat
    static void CancelSeat()
    {
        Console.Write("Enter row (1-5): ");
        int row = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter column (1-5): ");
        int col = int.Parse(Console.ReadLine()) - 1;

        if (row < 0 || row > 4 || col < 0 || col > 4)
        {
            Console.WriteLine("Invalid seat position. Please try again.");
        }
        else if (seats[row, col] == "X")
        {
            seats[row, col] = " "; // Mark the seat as available again
            Console.WriteLine("Seat canceled successfully.");
        }
        else
        {
            Console.WriteLine("This seat is not booked.");
        }

        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    // Method to check availability of a particular seat
    static void CheckAvailability()
    {
        Console.Write("Enter row (1-5): ");
        int row = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Enter column (1-5): ");
        int col = int.Parse(Console.ReadLine()) - 1;

        if (row < 0 || row > 4 || col < 0 || col > 4)
        {
            Console.WriteLine("Invalid seat position. Please try again.");
        }
        else if (seats[row, col] == "X")
        {
            Console.WriteLine("The seat is already booked.");
        }
        else
        {
            Console.WriteLine("The seat is available.");
        }

        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }
}
