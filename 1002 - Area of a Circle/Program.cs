using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {

        /*Double n = 3.14159;
        Double r = Convert.ToDouble(Console.ReadLine());
        Double a = n * Math.Pow(r, 2);
        Console.WriteLine($"A = {a.ToString("F4", CultureInfo.InvariantCulture)}");
    */

        double n = 3.14159;
        double R = Convert.ToDouble(Console.ReadLine());
        double A = n * Math.Pow(R, 2.00);
        string s = A.ToString("F4");
        System.Console.WriteLine("A=" + s);

    }

}
