using System;

class Program
{
    static void Main()
    {
        int estoque = 0;
        int quantidade;

        Console.WriteLine("Informe as quantidades de produtos recebidos (positivo) ou vendidos (negativo). Digite 0 para encerrar:");

        do
        {
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            estoque += quantidade; 

        } while (quantidade != 0); 

        Console.WriteLine($"Quantidade total de produtos em estoque: {estoque}");
    }
}