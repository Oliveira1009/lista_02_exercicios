using System;

class Program
{
    static void Main()
    {
        int totalPassagens = 0;

        Console.WriteLine("Digite o valor das passagens vendidas (valor negativo para encerrar):");

        for (double valor = double.Parse(Console.ReadLine()); valor >= 0; valor = double.Parse(Console.ReadLine()))
        {
            totalPassagens++;
        }

        Console.WriteLine("Total de passagens vendidas: " + totalPassagens);
    }
}
