using System;

class Program
{
    static void Main()
    {
        int totalIdades = 0;
        int quantidade = 0;
        int idade;

        Console.WriteLine("Informe as idades dos amigos (digite 0 para encerrar):");

        do
        {
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade > 0)
            {
                totalIdades += idade; 
                quantidade++; 
            }
            else if (idade < 0)
            {
                Console.WriteLine("Idade inválida! Digite um valor maior que 0.");
            }

        } while (idade != 0); 

        if (quantidade > 0)
        {
            double media = (double)totalIdades / quantidade; 
            Console.WriteLine($"A média das idades é: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhuma idade foi inserida.");
        }
    }
}