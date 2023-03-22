using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        string name = Convert.ToString(Console.ReadLine());
        Double salaryFixed = Convert.ToDouble(Console.ReadLine());
        Double sales = Convert.ToDouble(Console.ReadLine());
        Double salary = salaryFixed + sales * 15 / 100;
        Console.WriteLine($"TOTAL = R$ {salary:F2}");

    }
}