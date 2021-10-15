using System;
using MetodosConstrutores.Classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(01, "Banana", "Nanica", 100);
            
            Produto produto2 = new Produto(1);

            Produto produto3 = new Produto();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Código: {produto3.Codigo}\nNome: {produto3.Nome ?? "Nome não inserido"}\nDescrição: {produto3.Descricao ?? "Descrição não encontrada."}\nEstoque: {produto3.Estoque}");
                Console.ResetColor();

        }
    }
}
