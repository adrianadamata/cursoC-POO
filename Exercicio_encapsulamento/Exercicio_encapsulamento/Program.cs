using System;
using System.Globalization;

namespace Exercicio_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string tit;
            char opcao;

            Conta conta;

            Console.Write("Entre o número da conta: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            tit = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?  ");
            opcao = char.Parse(Console.ReadLine());
            if (opcao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(num, tit, depositoInicial);
            }
            else
            {
                conta = new Conta(num, tit);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarDeposito(dep);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RetirarSaque(saq);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
