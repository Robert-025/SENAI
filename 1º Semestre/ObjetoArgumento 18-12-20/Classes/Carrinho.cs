using System;
using System.Collections.Generic;

namespace ObjetoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (var item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"Código: {item.Codigo} - Nome: {item.Nome} - Preço: {item.Preco}");

                    Console.ResetColor();  
                }
                MostrarTotal();
            }
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostrarTotal()
        {
            if (carrinho != null)
            {
                ValorTotal = 0;
                foreach (var item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"O total do carrinho é: R${ValorTotal}");
            }
            else{
                Console.WriteLine($"Seu carrinho está vazio.");
                
            }
        }

        public void AlterarItem(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;

            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}