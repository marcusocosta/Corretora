namespace Corretora.Domain.Entities
{
    public class Extrato
    {
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
        public double Credito { get; set; }

        public Extrato(int numeroConta, double saldo, double credito)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Credito = credito;            
        }

    }
}