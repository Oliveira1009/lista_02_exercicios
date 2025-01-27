using System;

class Program
{
    static void Main()
    {
        int diasTrabalhados = 0;
        int dia;

        Console.WriteLine("Informe os dias trabalhados (1 a 31). Digite 0 para terminar:");

        for (;;) 
        {
            dia = int.Parse(Console.ReadLine());

            if (dia == 0)
            {
                break;

            if (dia >= 1 && dia <= 31)
            {
                diasTrabalhados++;
            }
            else
            {
                Console.WriteLine("Dia inválido! Digite um valor entre 1 e 31.");
            }
        }

        Console.WriteLine($"Total de dias trabalhados no mês: {diasTrabalhados}");
    }
}