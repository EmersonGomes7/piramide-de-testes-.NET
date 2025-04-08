using Xunit;
using System.Collections.Generic;
namespace Pyramid.Core;

public class ClienteIntegrationTests
{
    [Fact]
    public void Cliente_Deve_Poder_Adicionar_Orcamento()
    {
        var cliente = new Cliente { Nome = "maria" };
        var orcamento = new Orcamento { Id = 3 };

        cliente.Orcamentos.Add(orcamento);

        Assert.Single(cliente.Orcamentos);
        Assert.Equal(3, cliente.Orcamentos[0].Id);
    }

    [Fact]
    public void Cliente_Deve_Poder_Ter_Multiplos_Orcamentos()
    {
        var cliente = new Cliente { Nome = "andré" };
        var orcamento1 = new Orcamento { Id = 1 };
        var orcamento2 = new Orcamento { Id = 2 };

        cliente.Orcamentos.Add(orcamento1);
        cliente.Orcamentos.Add(orcamento2);

        Assert.Equal(2, cliente.Orcamentos.Count);
    }

    [Fact]
    public void Cliente_Deve_Poder_Remover_Orcamento()
    {
        var cliente = new Cliente { Nome = "ana" };
        var orcamento = new Orcamento { Id = 4 };

        cliente.Orcamentos.Add(orcamento);
        cliente.Orcamentos.Remove(orcamento);

        Assert.Empty(cliente.Orcamentos);
    }

    [Fact]
    public void Cliente_Orcamento_Deve_Calcular_Total_Corretamente()
    {
        var cliente = new Cliente { Nome = "emerson" };
        var orcamento = new Orcamento { Id = 5 };

        orcamento.AdicionarItem("roupa", 150);
        orcamento.AdicionarItem("geladeira", 600);
        cliente.Orcamentos.Add(orcamento);

        Assert.Equal(750, cliente.Orcamentos[0].valorTotal);
    }
}
