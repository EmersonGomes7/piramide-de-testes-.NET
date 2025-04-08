using Xunit;
using System.Collections.Generic;
namespace Pyramid.Core;

public class OrcamentoTests
{
    [Fact]
    public void Orcamento_Deve_Ter_Id_Valido()
    {
        var orcamento = new Orcamento { Id = 1 };

        Assert.Equal(1, orcamento.Id);
    }

    [Fact]
    public void AdicionarItem_Deve_Atualizar_ValorTotal(){
    
        var orcamento = new Orcamento { Id = 2 };

        orcamento.AdicionarItem("passagem", 500);
        orcamento.AdicionarItem("caderno", 10);

        Assert.Equal(510, orcamento.valorTotal);
    }
}
