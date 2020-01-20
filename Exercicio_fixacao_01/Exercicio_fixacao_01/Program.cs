using System;
using System.Globalization;

namespace Exercicio_fixacao_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;
            x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = {0}", x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = {0}", x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = {0}", x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
