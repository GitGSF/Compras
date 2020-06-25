using System;

namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
        Produto p1 = new Produto(1,"PS5",4000.00f);
        Produto p2 = new Produto(2,"Xbox One X",2350.00f);
        Produto p3 = new Produto(3,"Nintendo Switch",1850.00f);
        Produto p4 = new Produto(4,"PS3",800.00f);
        Produto p5 = new Produto(5,"Xbox 360",650.00f);

           Carrinho carrinho = new Carrinho();
           carrinho.AdicionarProduto(p1);
           carrinho.AdicionarProduto(p2);
           carrinho.AdicionarProduto(p3);
           carrinho.AdicionarProduto(p4);
           carrinho.AdicionarProduto(p5);
           
           carrinho.MostrarProdutos();
        }
    }
}
