using System;
using System.Collections.Generic;
namespace Pyramid.Core;

class Program{
    static void Main(){
        Cliente cliente = new Cliente{Nome="joão"};

        Orcamento orcamento=new Orcamento{Id=1};
        orcamento.AdicionarItem("Notebook",5000);
        orcamento.AdicionarItem("Mouse",100);

        cliente.Orcamentos.Add(orcamento);

        Console.WriteLine($"Cliente: {cliente.Nome}");
        Console.WriteLine($"Orçamento {orcamento.Id} - total: {orcamento.valorTotal} ");
    }
}