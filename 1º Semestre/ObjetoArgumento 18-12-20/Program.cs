using System;
using ObjetoArgumento.Classes;

namespace ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando o produto
            Produto produto1 = new Produto(1,"Read Dead Redemption", 499f);
            Produto produto2 = new Produto(2, "GTA V", 59.9f);
            Produto produto3 = new Produto(3, "Detroid Become", 99.9f);

            Produto produto4 = new Produto(4, "Bully", 24.9f);  

            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(produto1);
            cart.AdicionarProduto(produto2);
            cart.AdicionarProduto(produto3);
            cart.AdicionarProduto(produto4);

            cart.MostrarProdutos();

            Console.WriteLine($"Deseja remover algum item? (S/N)");
            string resposta = Console.ReadLine();
            
            if (resposta.ToUpper() == "S")
            {
                Console.WriteLine($"Qual item você deseja remover? 1, 2, 3 ou 4?");
                int item = int.Parse(Console.ReadLine());

                switch (item)
                {
                    case 1:
                        cart.RemoverProduto(produto1);
                      break;
                    case 2:
                        cart.RemoverProduto(produto2);
                      break;
                       case 3:
                        cart.RemoverProduto(produto3);
                      break;
                       case 4:
                        cart.RemoverProduto(produto4);
                      break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"São esses os produtos que estão no seu carrinho:");

            cart.MostrarProdutos();

            Produto produto5 = new Produto(5, "GTA San Andreas", 100f);

            cart.AlterarItem(1, produto5);
        }
    }
}
