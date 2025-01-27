using System;

class Program
{
    static void Main()
    {
        double totalCompras = 0;

        Console.WriteLine("Digite o valor das compras (0 para encerrar):");

        for (double valor = double.Parse(Console.ReadLine()); valor != 0; valor = double.Parse(Console.ReadLine()))
        {
            totalCompras += valor;
        }

        Console.WriteLine("Total das compras: R$ " + totalCompras.ToString("F2"));
    }
}
