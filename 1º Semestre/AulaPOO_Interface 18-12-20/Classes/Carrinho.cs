using System;
using System.Collections.Generic;

namespace AulaPOO_Interface.Classes
{
    public class Carrinho : ICarrinho
    {

        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Listar()
        {
            foreach (var item in carrinho)
            {
                Console.WriteLine($"Produto: {item.Nome} - Código: {item.Codigo} - Preço: {item.Preco}");
            }
            MostarValor();
        }

        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostarValor()
        {
            if (carrinho != null)
            {
                ValorTotal = 0;

                foreach (var item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"\nO valor do seu carrinho é: R${ValorTotal}");
                
            }else{
                Console.WriteLine($"Seu carrinho está vazio.");
            }
        }
    }
}