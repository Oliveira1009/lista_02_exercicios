using System;

class Program
{
    static void Main()
    {
        int totalMinutos = 0;
        int duracao;

        Console.WriteLine("Digite a duração das chamadas em minutos (0 para encerrar):");

        do
        {
            duracao = int.Parse(Console.ReadLine());
            totalMinutos += duracao;
        } while (duracao != 0);

        totalMinutos -= duracao;

        Console.WriteLine("Total de minutos atendidos: " + totalMinutos);
    }
}
