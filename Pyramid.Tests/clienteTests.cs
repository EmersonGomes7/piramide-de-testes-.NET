using Xunit;
namespace Pyramid.Core;
public class ClienteTests
{
    [Fact]
    public void Cliente_Deve_Ter_Nome_Valido()
    {
        var cliente = new Cliente{ Nome = "João" };

        Assert.NotNull(cliente.Nome);
        Assert.NotEmpty(cliente.Nome);
    }

    [Fact]
    public void Cliente_Deve_Poder_Adicionar_Orcamento()
    {
        
        var cliente = new Cliente { Nome = "Maria" };
        var orcamento = new Orcamento { Id = 3 };

        cliente.Orcamentos.Add(orcamento);

        Assert.Single(cliente.Orcamentos);
        Assert.Equal(3, cliente.Orcamentos[0].Id);
    }
}

