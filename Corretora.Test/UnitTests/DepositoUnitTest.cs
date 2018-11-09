using System;
using Corretora.Domain.Entities;
using Xunit;

namespace Corretora.Test
{
    public class CalculoCreditoUnitTest
    {
        [Fact]
        public void DeveRetornarZeroQuandoOValorDoParametroForMenorQueOLimite()
        {
            var deposito = 999;
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());
            
            var result = conta.Deposito(deposito);

            Assert.Equal(0, result.Credito);
            Assert.Equal(deposito, result.Saldo);
        }

        [Fact]
        public void DeveRetornar10QuandoOValorDoDepositoFor1000Limite1000ETaxa1Porcento()
        {
            var deposito = 1000;
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());
            
            var result = conta.Deposito(deposito);

            Assert.Equal(10, result.Credito);
            Assert.Equal(deposito, result.Saldo);
        }

        [Fact]
        public void DeveRetornar12QuandoOValorDoDepositoFor1200Limite1000ETaxa1Porcento()
        {
            var deposito = 1200;
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());
            
            var result = conta.Deposito(deposito);

            Assert.Equal(12, result.Credito);
            Assert.Equal(deposito, result.Saldo);
        }
    }
}
