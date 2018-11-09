using System;

namespace Corretora.Domain.Entities
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int numeroConta, Guid codigoPessoa)
        {
            if (agencia <= 0 || numeroConta <= 0)
                throw new ArgumentOutOfRangeException();

            Agencia = agencia;
            NumeroConta = numeroConta;
            CodigoPessoa = codigoPessoa;
            Saldo = 0;
            Credito = 0;
        }

        public int Agencia { get; set; }

        public int NumeroConta { get; set; }

        public Guid CodigoPessoa { get; set; }

        public double Saldo { get; set; }

        public double Credito { get; set; }

        private double CalculoCredito(double deposito)
        {
            if (deposito < 1000)
            {
                return 0;
            }

            return deposito * 0.01;
        }

        public Extrato Deposito(double valor)
        {
            Saldo = Saldo + valor;
            Credito = Credito + CalculoCredito(valor);

            return new Extrato(NumeroConta, Saldo, Credito);
        }

        public Extrato Extrato()
        {
            return new Extrato(NumeroConta, Saldo, Credito);
        }

    }
}