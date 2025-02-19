using System;
interface Bank 
{
    public void roi(); 
}
class ICICI: Bank
{
    public void roi() 
    {
        Console.WriteLine("ICICI Interest Rate: 7%");
    }
}
class HDFC:Bank 
{
    public void roi() 
    {
       Console.WriteLine("HDFC Interest Rate:6.5%");
    }
}

class SBI:Bank
{
     public void roi() 
     {
        Console.WriteLine("SBI Interest Rate: 6.5%");
    }
}
class Test
{
public static void Main()
{
    Bank b;
    b=new ICICI();
    b.roi();
    b=new HDFC();
    b.roi();
    b=new SBI();
    b.roi();
    }
}
