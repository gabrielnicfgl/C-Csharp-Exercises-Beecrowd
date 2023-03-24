using System;

class URI
{

    static void Main(string[] args)
    {

        string[] prod1 = Console.ReadLine().Split(' ');

        int code = Convert.ToInt32(prod1[0]);
        int unit = Convert.ToInt32(prod1[1]);
        double price = Convert.ToDouble(prod1[2]);

        string[] prod2 = Console.ReadLine().Split(' ');

        int code2 = Convert.ToInt32(prod2[0]);
        int unit2 = Convert.ToInt32(prod2[1]);
        double price2 = Convert.ToDouble(prod2[2]);

        double total = (unit * price) + (unit2 * price2);
        System.Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");




    }

}