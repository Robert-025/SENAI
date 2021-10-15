using System;

namespace MetodosConstrutores.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        
        public Produto(int codigo, string nome, string desc, int estoque)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (codigo < 0)
            {
                Console.WriteLine($"Valor inválido");
                
            }
            else{

                Codigo = codigo;
                Nome = nome; 
                Descricao = desc;
                Estoque = estoque;

                Console.WriteLine($"Produto cadastrado. \nCódigo: {codigo} - nome: {nome} - descrição: {desc} - estoque: {estoque} \n");
            }
            Console.ResetColor();
        }

        public Produto(int codigo)
        {
            if (codigo >= 0)
            {
                Codigo = codigo;
                Nome = "Coca-Cola";
                Console.WriteLine($"Produto cadastrado. \nCódigo: {codigo} - Nome: {Nome ?? "não existe"}\n");
            }
            
        }

        public Produto(){} 
    }
}