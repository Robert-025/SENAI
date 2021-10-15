using System;

namespace Atividade_13_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;

            /* Console.WriteLine("Você viveu: " + meses + " meses, " + dias + " dias, " + horas + " horas e " + minutos + " minutos. ");
 */

            Console.Write("Você viveu: ");
            Console.Write(meses + " meses, ");
            Console.Write(dias + " dias, ");
            Console.Write(horas + " horas e ");
            Console.Write(minutos + " minutos. ");
        }
    }
}
