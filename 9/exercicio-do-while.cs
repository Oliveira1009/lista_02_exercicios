using System;

class Program
{
    static void Main()
    {
        double totalCompras = 0;
        double valor;

        Console.WriteLine("Digite o valor das compras (0 para encerrar):");

        do
        {
            valor = double.Parse(Console.ReadLine());
            totalCompras += valor;
        } while (valor != 0);

        totalCompras -= valor;

        Console.WriteLine("Total das compras: R$ " + totalCompras.ToString("F2"));
    }
}
