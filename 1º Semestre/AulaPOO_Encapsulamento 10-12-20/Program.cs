using System;
using AulaPOO_Encapsulamento.Classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           MasterCard mc = new MasterCard();

           mc.NomeTitular = Console.ReadLine();

           mc.Numero = Console.ReadLine();

           mc.Bandeira = Console.ReadLine();

           mc.Cvv = Console.ReadLine(); 

           mc.ValorCompra = float.Parse( Console.ReadLine() );

           mc.produto = Console.ReadLine();

           Console.WriteLine($"Deseja parcelar em quantas vezes? ");
           mc.Parcelas = int.Parse( Console.ReadLine() );
           
           

           Console.WriteLine($"{mc.NomeTitular}");
           Console.WriteLine($"{mc.Numero}");
           Console.WriteLine($"{mc.Bandeira}");
           Console.WriteLine($"{mc.Token}");
           Console.WriteLine($"{mc.Cvv}");
           Console.WriteLine($"{mc.Limite}");
           Console.WriteLine($"{mc.ValorCompra}");
           Console.WriteLine($"{mc.produto}");

                      
        }
    }
}
