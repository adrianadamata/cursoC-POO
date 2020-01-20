using System;
using System.Globalization;

namespace Exercicio_fixacao_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;
            x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: {0}", x);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            int percent = int.Parse(Console.ReadLine());
            x.AumentarSalario(percent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}", x);
        }
    }
}
