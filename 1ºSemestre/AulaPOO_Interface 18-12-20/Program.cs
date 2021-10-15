using System;
using AulaPOO_Interface.Classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            
            Produto p1 = new Produto(1, "Playstation 5", 8000f);
            Produto p2 = new Produto(2, "XBOX series X", 5000f);
            Produto p3 = new Produto(3, "PC Gamer", 4000f);
            Produto p4 = new Produto(4, "Nitendo Switch", 3000f);

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);

            Console.ForegroundColor = ConsoleColor.Green;

            carrinho.Listar();
            Console.WriteLine($"\n");
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            carrinho.Alterar(1, p4);
            carrinho.Listar();
            Console.WriteLine($"\n");
            
            Console.ForegroundColor = ConsoleColor.Red;

            carrinho.Deletar(p2);
            carrinho.Listar();

            Console.ResetColor();

            
            
        }
    }
}
