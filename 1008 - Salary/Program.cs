using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int hoursWokerd = Convert.ToInt32(Console.ReadLine());
        Decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());
        Decimal salary = hourlyRate * hoursWokerd;

        System.Console.WriteLine($"NUMBER = {number} ");
        System.Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}