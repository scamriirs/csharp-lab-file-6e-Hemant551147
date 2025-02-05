using System;

class Program{
    static void Main(){
        double PA, cashback = 0.0;
        Console.Write("Enter the purchase amount (in Rs.): ");
        PA = Convert.ToDouble(Console.ReadLine());
        if (PA < 1000){
            cashback = 0.0; }
        else if (PA >= 1000 && PA < 5000){
            cashback = 0.05 * PA;  }
        else if (PA >= 5000 && PA < 10000){
            cashback = 0.10 * PA;  }
        else{
            cashback = 0.15 * PA; }
  Console.WriteLine("Your cashback is: Rs." + cashback);
    }}
