using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite um valor:");
            Conversor.valorUsuario = float.Parse( Console.ReadLine() );

            Console.WriteLine($"U${Conversor.valorUsuario} em Reais é igual: R$ {Conversor.DolarPraReal(Conversor.valorUsuario)} ");
            Console.WriteLine($"R${Conversor.valorUsuario} Dólares é igual: U$ {Conversor.RealPraDolar(Conversor.valorUsuario)}"  );

            Console.WriteLine($"{Conversor.valorUsuario} Euros em Reais é igual: R$ {Conversor.EuroPraReal(Conversor.valorUsuario)}" );
            Console.WriteLine($"R${Conversor.valorUsuario} em Euros é igual: {Conversor.RealPraEuro(Conversor.valorUsuario)}" );
            
            

        }
    }
}
