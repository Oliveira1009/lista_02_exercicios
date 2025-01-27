using System;

class Program
{
    static void Main()
    {
        int totalMinutos = 0;
        int duracao;

        Console.WriteLine("Digite a duração das chamadas em minutos (0 para encerrar):");
        duracao = int.Parse(Console.ReadLine());

        while (duracao != 0)
        {
            totalMinutos += duracao;
            duracao = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total de minutos atendidos: " + totalMinutos);
    }
}
