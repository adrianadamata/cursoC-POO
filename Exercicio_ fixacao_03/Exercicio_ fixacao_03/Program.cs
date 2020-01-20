using System;
using System.Globalization;

namespace Exercicio__fixacao_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            x.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = {0}", x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (x.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", x.FaltouPontos().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
