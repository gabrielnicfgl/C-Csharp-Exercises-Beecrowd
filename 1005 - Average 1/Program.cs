
using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        Double peso1 = 3.5;
        Double peso2 = 7.5;

        Double a = Convert.ToDouble(Console.ReadLine());
        Double b = Convert.ToDouble(Console.ReadLine());
        Double media = (a * peso1 + b * peso2) / 11;

        Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

}