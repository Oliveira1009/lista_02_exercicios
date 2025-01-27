using System;

class Program
{
    static void Main()
    {
        double totalCompras = 0;
        double valor;

        Console.WriteLine("Digite o valor das compras (0 para encerrar):");
        valor = double.Parse(Console.ReadLine());

        while (valor != 0)
        {
            totalCompras += valor;
            valor = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total das compras: R$ " + totalCompras.ToString("F2"));
    }
}
