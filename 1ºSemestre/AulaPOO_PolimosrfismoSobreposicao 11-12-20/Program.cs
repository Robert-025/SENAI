using System;
using AulaPOO_PolimosrfismoSobreposicao.Classes;

namespace AulaPOO_PolimosrfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan mega = new MegaMan();

            mega.Correr();

            Zero zero = new Zero(); 

            zero.Pular();
        }
    }
}
