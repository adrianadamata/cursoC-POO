using System;


namespace Exercicio_fixacao_04
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double cot, double qtde)
        {
            return (cot * qtde) * (1 + (Iof / 100));
        }


    }
}
