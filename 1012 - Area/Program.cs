using System;


class Uri
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');

        double a = Convert.ToDouble(valores[0]);
        double b = Convert.ToDouble(valores[1]);
        double c = Convert.ToDouble(valores[2]);
        double pi = 3.14159;

        double triangle = a * c / 2;
        double circle = pi * Math.Pow(c, 2);
        double trapezoid = (a + b) / 2 * c;
        double square = Math.Pow(b, 2);
        double rectangle = a * b;

        System.Console.WriteLine($"TRIANGULO: {triangle:F3}");
        System.Console.WriteLine($"CIRCULO: {circle:F3}");
        System.Console.WriteLine($"TRAPEZIO: {trapezoid:F3}");
        System.Console.WriteLine($"QUADRADO: {square:F3}");
        System.Console.WriteLine($"RETANGULO: {rectangle:F3}");

    }
}