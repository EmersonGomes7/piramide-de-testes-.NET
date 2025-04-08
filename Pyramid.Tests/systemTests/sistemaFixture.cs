using Xunit;
using System.Collections.Generic;
namespace Pyramid.Core;
    public class SistemaFixture
    {
        public Cliente CriarClienteComOrcamento()
        {
            var cliente = new Cliente { Nome = "Carlos" };
            var orcamento = new Orcamento { Id = 1 };
            orcamento.AdicionarItem("Notebook", 3000);
            orcamento.AdicionarItem("Mouse", 150);
            cliente.Orcamentos.Add(orcamento);
            return cliente;
        }
    }

    public class SistemaTests : IClassFixture<SistemaFixture>
    {
        private readonly SistemaFixture _fixture;

        public SistemaTests(SistemaFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Criar_Orcamento_Com_Itens_Deve_Calcular_Total_Corretamente()
        {
            var cliente = _fixture.CriarClienteComOrcamento();
            Assert.Equal(3150, cliente.Orcamentos[0].valorTotal);
        }

        [Fact]
        public void Remover_Item_Deve_Recalcular_Total()
        {
            var cliente = _fixture.CriarClienteComOrcamento();
            cliente.Orcamentos[0].RemoverItem("Mouse");
            Assert.Equal(3000, cliente.Orcamentos[0].valorTotal);
        }

        [Fact]
        public void Orcamento_Com_Valor_Zero_Deve_Ser_Invalido()
        {
            var cliente = new Cliente { Nome = "Ana" };
            var orcamento = new Orcamento { Id = 2 };
            cliente.Orcamentos.Add(orcamento);
            Assert.False(orcamento.Validar());
        }

        [Fact]
        public void Cliente_Com_Orcamento_Acima_De_5000_Deve_Ter_Desconto()
        {
            var cliente = new Cliente { Nome = "Mariana" };
            var orcamento = new Orcamento { Id = 3 };
            orcamento.AdicionarItem("Smart TV", 5500);
            cliente.Orcamentos.Add(orcamento);
            
            Assert.True(orcamento.AplicarDesconto());
        }
    }
