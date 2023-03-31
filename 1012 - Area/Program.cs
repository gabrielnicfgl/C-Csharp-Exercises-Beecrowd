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

        double triangle = a * c / 2; // Area do triangulo é o produto do lado A e C dividido por dois
        double circle = pi * Math.Pow(c, 2); //A área do circulo é o produto de PI e C²
        double trapezoid = (a + b) / 2 * c; // A área do trapézio é o soma das bases (A e B) dividida por dois e multiplicada pela altura(C)
        double square = Math.Pow(b, 2);// A área do quadrado é a exponenciação de um dos seus lados iguais.
        double rectangle = a * b;// Nesse exemplo. é o produto entre o lado A e B

        System.Console.WriteLine($"TRIANGULO: {triangle:F3}");
        System.Console.WriteLine($"CIRCULO: {circle:F3}");
        System.Console.WriteLine($"TRAPEZIO: {trapezoid:F3}");
        System.Console.WriteLine($"QUADRADO: {square:F3}");
        System.Console.WriteLine($"RETANGULO: {rectangle:F3}");

    }
}