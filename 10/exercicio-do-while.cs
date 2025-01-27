using System;

class Program
{
    static void Main()
    {
        int totalPassagens = 0;
        double valor;

        Console.WriteLine("Digite o valor das passagens vendidas (valor negativo para encerrar):");

        do
        {
            valor = double.Parse(Console.ReadLine());
            if (valor >= 0)
            {
                totalPassagens++;
            }
        } while (valor >= 0);

        Console.WriteLine("Total de passagens vendidas: " + totalPassagens);
    }
}
