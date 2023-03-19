using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        Double peso1 = 2.0;
        Double peso2 = 3.0;
        Double peso3 = 5.0;

        Double nota1 = Convert.ToDouble(Console.ReadLine());
        Double nota2 = Convert.ToDouble(Console.ReadLine());
        Double nota3 = Convert.ToDouble(Console.ReadLine());

        Double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

        Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");

    }

}