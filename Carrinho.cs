using System.Collections.Generic;
using System;

namespace Compras
{
    public class Carrinho
    {
        //Lista Carrinho
        List<Produto> carrinho = new List<Produto>();

        //Guardar valor produtos
        public float ValorTotal { get; set; }

        //Método adiciona Produtos ao carrinho passando o objeto como argumento
        public void AdicionarProduto(Produto Produto)
        {
            carrinho.Add(Produto);
        }
        //Método listar os produtos do carrinho
        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($" {p.Nome} - R${p.Preco.ToString("n2")}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
        //Método Mostrar Valor total dos Produtos do Carrinho
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            if(carrinho!=null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                System.Console.WriteLine($"Valor total de itens do carrinho R${ValorTotal.ToString("n2")}");
            }else{
                System.Console.WriteLine($"Seu carrinho está vazio, adicione itens e consulte novamente!");
            }
            Console.ResetColor();
        }
    }
}