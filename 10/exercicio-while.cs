using System;

class Program
{
    static void Main()
    {
        int totalPassagens = 0;
        double valor;

        Console.WriteLine("Digite o valor das passagens vendidas (valor negativo para encerrar):");
        valor = double.Parse(Console.ReadLine());

        while (valor >= 0)
        {
            totalPassagens++;
            valor = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total de passagens vendidas: " + totalPassagens);
    }
}
