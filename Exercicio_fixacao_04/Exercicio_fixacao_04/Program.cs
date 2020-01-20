using System;
using System.Globalization;

namespace Exercicio_fixacao_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.DolarParaReal(cotacao, qtde);
            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
