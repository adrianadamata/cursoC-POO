using System;
using System.Globalization;

namespace Exercicio__fixacao_03
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;
       
        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }
        
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FaltouPontos()
        {
            return 60.0 - NotaFinal();
        }
    }
}
