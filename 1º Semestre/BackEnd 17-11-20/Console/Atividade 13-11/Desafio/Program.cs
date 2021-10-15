using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("---------------------------");

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            if(idade >= 5 && idade <= 7){
                Console.WriteLine($"{nome}, você está na categoria: Infantil A." );
            }
            if(idade >= 8 && idade <= 10){
                Console.WriteLine($"{nome}, você está na categoria: Infantil B." );
            }
            if(idade >= 11 && idade <= 13){
                Console.WriteLine($"{nome}, você está na categoria: Juvenil A." );
            }
            if(idade >= 14 && idade <= 17){
                Console.WriteLine($"{nome}, você está na categoria: Juvenil B." );
            }
            if(idade >= 18){
                Console.WriteLine($"{nome}, você está na categoria: Sênior." );
            }
        }
    }
}
