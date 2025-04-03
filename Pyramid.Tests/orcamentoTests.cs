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

        orcamento.AdicionarItem("Notebook", 5000);
        orcamento.AdicionarItem("Mouse", 100);

        Assert.Equal(5100, orcamento.valorTotal);
    }
}
