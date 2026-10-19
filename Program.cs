using System;

class program
{
    static decimal PlatinumToUSD(decimal ounces)
    {
        return ounces * 1634.00m;
    }
    static void Main()
    {
        decimal PlatinumOunces = 0.0m;
        Console.WriteLine("Please enter the Platinum ounces:");
        PlatinumOunces = Convert.ToDecimal(Console.ReadLine());

        decimal TotalUSD = 0.0m;
        decimal totalUSD = PlatinumToUSD(PlatinumOunces);
        Console.WriteLine($"Platinum value in USD today: {totalUSD:C2}");
    }
        
}