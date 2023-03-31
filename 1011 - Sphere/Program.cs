using System;

class uri
{
    static void Main(String[] args)
    {

        const Double PI = 3.14159;
        double a = Convert.ToDouble(Console.ReadLine());
        double vol = (4 / 3.0) * PI * Math.Pow(a, 3);

        System.Console.WriteLine($"VOLUME {vol:F3}"); // IMPORTANTE COLOCAR O NUMERO DA DIVISÃO DIVIDIDO POR UM NUMERO DECIMAL, CASO CONTRARIO, O PROGRAMA DIVIDE E TRUCA EXIBINDO APENAS A PARTE INTEIRA, OCASIONANDO NO ERRO DA EXIBIÇÃO CORRETA DO VALOR.




    }
}