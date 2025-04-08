
namespace Pyramid.Core;
public class Orcamento
{
    public int Id { get; set; }
    public decimal valorTotal { get; set; } = 0;
    public Dictionary<string, decimal> Itens { get; set; } = new Dictionary<string, decimal>();

    public void AdicionarItem(string item, decimal preco)
    {
        if (!Itens.ContainsKey(item))
        {
            Itens[item] = preco;
            valorTotal += preco;
        }
    }

    public void RemoverItem(string item)
    {
        if (Itens.ContainsKey(item))
        {
            valorTotal -= Itens[item];
            Itens.Remove(item);
        }
    }

    public bool Validar()
    {
        return valorTotal > 0;
    }

    public bool AplicarDesconto()
    {
        if (valorTotal > 5000)
        {
            valorTotal *= 0.9M; // aplica 10% de desconto
            return true;
        }else{
            return false;
        }
       
    }
}
