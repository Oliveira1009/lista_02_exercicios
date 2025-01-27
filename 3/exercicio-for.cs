using System;

class Program
{
    static void Main()
    {
        int aprovados = 0;
        double nota;

        Console.WriteLine("Informe as notas dos alunos (de 0 a 10). Digite -1 para encerrar:");

        for (;;) 
        {
            Console.Write("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());

            if (nota == -1)
            {
                break; 
            }

            if (nota >= 6 && nota <= 10)
            {
                aprovados++; 
            }
            else if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida! Digite um valor entre 0 e 10.");
            }
        }

        Console.WriteLine($"Total de alunos aprovados: {aprovados}");
    }
}