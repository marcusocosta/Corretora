# Tdd com .NET Core 2.1

Código desenvolvido na apresentação de TDD com .net Core na Softplan.

[Apresentação](https://poligraph-my.sharepoint.com/:p:/g/personal/marcus_costa_softplan_com_br/EQXV0qYlFSxPoISSTuWSIy4BwuaQ4QVLjl8AXUR_KfaZ0w?e=HuVMNc)

Rodar os testes com cobertura de teste
```bash
sh test.sh
```

## Problema
Você foi contratado para desenvolver um sistema simplificado para uma corretora de investimentos. No primeiro momento, será desenvolvido as funcionalidades de cadastro, depósito, saque e saldo para as contas dos investidores.​

Regras de negócio:​

**Cadastro:** A conta corrente deve conter os seguintes campos: Agencia, Número, Código da pessoa, Saldo e Crédito​

- Na criação da conta, os campos Agência, Número e Código da Pessoa são obrigatórios. O saldo e o crédito devem conter valores zerados.​

**Depósitos:** acima de R$1000,00 o investidor ganha 1% do valor investido em crédito na corretora. (este crédito não deve ser somado com junto com o saldo corrente).​

**Saques:** só podem ocorrer durante o horário de funcionamento da corretora (08:00 às 18:00).​

**Saldo:** deve retornar o valor corrente e os créditos do correntista.​

## Próximos passos
* Implemenatar a camada de API
* Implementar a camada de repositório
* Subir a imagem no Docker
