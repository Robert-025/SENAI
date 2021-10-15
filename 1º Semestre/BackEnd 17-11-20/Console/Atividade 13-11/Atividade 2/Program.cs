using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Insira seu ano de nascimento: ");
            int ano_nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Insira o ano atual: ");
            int ano_atual = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            int idade = ano_atual - ano_nascimento;
            int semanas = (idade * 365) / 7;
        
            Console.WriteLine(nome + ", você tem: " + idade + " anos e viveu " + semanas + " semanas. ");
        }
    }
}
