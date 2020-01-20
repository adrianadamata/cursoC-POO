using System;

namespace Exercicio_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            QuartoAlugado[] vect = new QuartoAlugado[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new QuartoAlugado(name, email);
            }
            Console.WriteLine("Quartos ocupados:");

            for (i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
