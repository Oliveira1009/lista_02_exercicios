using System;

class Program
{
    static void Main()
    {
        int votosA = 0;
        int votosB = 0;
        int voto;

        Console.WriteLine("Informe os votos (1 para candidato A, 2 para candidato B). Digite 0 para encerrar:");

        for (;;)
        {
            Console.Write("Digite o voto: ");
            voto = int.Parse(Console.ReadLine());

            if (voto == 0)
            {
                break;
            }

            if (voto == 1)
            {
                votosA++;
            }
            else if (voto == 2)
            {
                votosB++;
            }
            else
            {
                Console.WriteLine("Voto inválido! Digite 1 para candidato A, 2 para candidato B ou 0 para encerrar.");
            }
        }

        Console.WriteLine($"Total de votos para o candidato A: {votosA}");
        Console.WriteLine($"Total de votos para o candidato B: {votosB}");
    }
}
