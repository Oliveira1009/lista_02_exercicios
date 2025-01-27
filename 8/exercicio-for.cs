using System;

class Program
{
    static void Main()
    {
        int totalMinutos = 0;

        Console.WriteLine("Digite a duração das chamadas em minutos (0 para encerrar):");

        for (int duracao = int.Parse(Console.ReadLine()); duracao != 0; duracao = int.Parse(Console.ReadLine()))
        {
            totalMinutos += duracao;
        }

        Console.WriteLine("Total de minutos atendidos: " + totalMinutos);
    }
}
