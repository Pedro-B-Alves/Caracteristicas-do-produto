using System;
using Caracteristicas_do_produto.classes;

namespace Caracteristicas_do_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Coca-Cola";
            produto1.Descricao = "Refrigerante de cola";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome}, Descrição {produto1.Descricao}, Estoque {produto1.Estoque}");
            
            //Contrutor inserindo apenas o código

            Produto produto2 = new Produto(10);

            produto2.Nome = "Pepsi";

            Console.WriteLine($"Código inserido {produto2.Codigo}, nome {produto2.Nome}");

            //Construtor inserindo todos os valores

            Produto produto3 = new Produto(1,"Traquinas","Bolacha de Chocolate",1000);

            Console.WriteLine($"Código {produto3.Codigo}, nome {produto3.Nome}, Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");
            
            
        }
    }
}
