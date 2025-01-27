using System;

class Program
{
    static void Main()
    {
        double totalDespesas = 0;
        double despesa;

        Console.WriteLine("Informe suas despesas mensais (digite um valor negativo para terminar):");

        for (;;)
        {
            Console.Write("Digite o valor da despesa: ");
            despesa = double.Parse(Console.ReadLine());

            if (despesa < 0)
            {
                break;
            }

            totalDespesas += despesa;
        }

        Console.WriteLine($"Total de despesas mensais: R${totalDespesas:F2}");
    }
}