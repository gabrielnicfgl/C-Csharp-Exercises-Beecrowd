
using System;

class URI
{

    static void Main(string[] args)
    {

        string[] vet = Console.ReadLine().Split(' ');
        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);

        int ab = (a + b + Math.Abs(a - b)) / 2;
        int abc = (ab + c + Math.Abs(ab - c)) / 2;

        Console.WriteLine($"{abc}   eh o maior");

    }

}

