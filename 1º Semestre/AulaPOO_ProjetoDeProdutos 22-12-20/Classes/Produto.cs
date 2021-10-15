using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        public List<Produto> ListaDeProduto = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o código do produto:");
            novoProduto.Codigo = int.Parse( Console.ReadLine() );
            
            Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto:");
            novoProduto.Preco = float.Parse( Console.ReadLine() );

            //Chamando um método do objeto/propriedade Marca
            novoProduto.Marca = Marca.Cadastrar();

            //Usamos o método construtor para atribuir um objeto completo de usuário
            novoProduto.CadastradoPor = new Usuario();

            DataCadastro = DateTime.Today;

            ListaDeProduto.Add(novoProduto);
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            foreach (Produto item in ListaDeProduto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
            }

            Console.ResetColor();
        }

        public void Deletar(int cod)
        {
            Produto produtoDelete = ListaDeProduto.Find(x => x.Codigo == cod);
            ListaDeProduto.Remove(produtoDelete);
        }

    }
}