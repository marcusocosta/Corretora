using System;
using Corretora.Domain.Entities;
using Xunit;

namespace Corretora.Test
{
    public class ContaCorrenteUnitTest
    {
        [Theory]
        [InlineData("Agencia")]
        [InlineData("NumeroConta")]
        [InlineData("CodigoPessoa")]
        [InlineData("Saldo")]
        [InlineData("Credito")]
        public void QuandoCriadoAContaOsCamposObrigatoriosDevemExistir(string propertyName)
        {
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());

            Assert.NotNull(conta.GetType().GetProperty(propertyName));
        }


        [Fact]
        public void QuandoCriadoAContaONumeroDaContaDeveSerIgualAoValorPassado()
        {
            var numeroConta = 245567;
            var conta = new ContaCorrente(1212, numeroConta, Guid.NewGuid());

            Assert.Equal(numeroConta, conta.NumeroConta);
        }

        [Fact]
        public void QuandoCriadoAContaAAgenciaDeveSerIgualAoValorPassado()
        {
            var agencia = 1212;
            var conta = new ContaCorrente(agencia, 245567, Guid.NewGuid());

            Assert.Equal(agencia, conta.Agencia);
        }

        [Fact]
        public void QuandoCriadaAContaAAgenciaDeveSerMaiorQueZero()
        {
            var agencia = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new ContaCorrente(agencia, 245567, Guid.NewGuid()));
        }

        [Fact]
        public void QuandoCriadaAContaNumeroDaContaDeveSerMaiorQueZero()
        {
            var numeroConta = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => new ContaCorrente(1212, numeroConta, Guid.NewGuid()));
        }

        [Fact]
        public void QuandoCriadaAContaOSaldoDeveSerIgualAZero()
        {
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());

            Assert.Equal(0, conta.Saldo);
        }

        [Fact]
        public void QuandoCriadaAContaOCreditoDeveSerIgualAZero()
        {
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());

            Assert.Equal(0, conta.Credito);
        }
    }
}
