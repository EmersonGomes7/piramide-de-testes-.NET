using TechTalk.SpecFlow;
using Pyramid.Core;
using Xunit;

namespace Pyramid.Tests.Steps;

[Binding]
public class OrcamentoDescontoSteps
{
    private Cliente cliente= null!;
    private Orcamento orcamento= null!;
    private bool descontoAplicado;

    [Given(@"um cliente chamado ""(.*)""")]
    public void DadoUmClienteChamado(string nome)
    {
        cliente = new Cliente { Nome = nome };
        orcamento = new Orcamento { Id = 1 };
        cliente.Orcamentos.Add(orcamento);
    }

    [Given(@"ele adiciona um item chamado ""(.*)"" com valor (.*)")]
    public void DadoEleAdicionaUmItemChamadoComValor(string item, decimal valor)
    {
        orcamento.AdicionarItem(item, valor);
    }

    [When(@"o orçamento é verificado para desconto")]
    public void QuandoOOrcamentoÉVerificadoParaDesconto()
    {
        descontoAplicado = orcamento.AplicarDesconto();
    }

    [Then(@"o orçamento deve ter desconto aplicado")]
    public void EntaoOOrcamentoDeveTerDescontoAplicado()
    {
        Assert.True(descontoAplicado);
    }
}
