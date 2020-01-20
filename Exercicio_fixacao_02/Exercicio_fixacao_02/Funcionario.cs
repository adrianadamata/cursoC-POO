using System;
using System.Globalization;

namespace Exercicio_fixacao_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
           return SalarioBruto - Imposto;
        }

        public void AumentarSalario(int i)
        {
            SalarioBruto += SalarioBruto * i / 100;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
