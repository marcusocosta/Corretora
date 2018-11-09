using System;
using Corretora.Domain.Entities;
using Xunit;

namespace Corretora.Test
{
    public class ExtratoUnitTest
    {
        [Theory]
        [InlineData("NumeroConta")]
        [InlineData("Saldo")]
        [InlineData("Credito")]
        public void DeveRetornarCamposObrigatoriosNoExtrato(string propertyName)
        {
            var conta = new ContaCorrente(1212, 245567, Guid.NewGuid());

            Assert.NotNull(conta.GetType().GetProperty(propertyName));
        }
    }
}
