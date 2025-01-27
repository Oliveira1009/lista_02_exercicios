using System;

class Program
{
    static void Main()
    {
        double distanciaTotal = 0;
        double distancia;

        Console.WriteLine("Informe as distâncias percorridas em cada dia (digite um valor negativo para encerrar):");

        do
        {
            Console.Write("Digite a distância: ");
            distancia = double.Parse(Console.ReadLine());

            if (distancia >= 0)
            {
                distanciaTotal += distancia;
            }

        } while (distancia >= 0);

        Console.WriteLine($"Distância total percorrida: {distanciaTotal:F2} km");
    }
}