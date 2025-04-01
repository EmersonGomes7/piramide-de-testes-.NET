namespace Pyramid.Core;
public class Orcamento{
    public int Id{get;set;}
    public decimal valorTotal{get;set;}
    public List<string> Itens {get;set;}=new List<string>();

    public void AdicionarItem(string item,decimal preco){
        Itens.Add(item);
        valorTotal +=preco;
    }

}