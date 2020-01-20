using System;
using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiro, segundo;
            double media;

            primeiro = new Funcionario();
            segundo = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            primeiro.Nome = Console.ReadLine();
            Console.Write("Salário:");
            primeiro.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            segundo.Nome = Console.ReadLine();
            Console.Write("Salário:");
            segundo.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (primeiro.Salário + segundo.Salário) / 2;

            Console.WriteLine("Salário médio: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
