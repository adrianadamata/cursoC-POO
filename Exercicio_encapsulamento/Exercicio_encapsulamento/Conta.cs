using System.Globalization;

namespace Exercicio_encapsulamento
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero,titular)
        {
            AdicionarDeposito(depositoInicial);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarDeposito(double deposito)
        {
            Saldo += deposito;
        }

        public void RetirarSaque (double saque)
        {
            Saldo -= saque + 5.0;
        }
    }
}
