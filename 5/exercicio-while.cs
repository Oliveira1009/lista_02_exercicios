using System;

class Program
{
    static void Main()
    {
        int estoque = 0;
        int quantidade;

        Console.WriteLine("Informe as quantidades de produtos recebidos (positivo) ou vendidos (negativo). Digite 0 para encerrar:");

        while (true)
        {
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (quantidade == 0)
            {
                break; 
            }

            estoque += quantidade;
        }

        Console.WriteLine($"Quantidade total de produtos em estoque: {estoque}");
    }
}