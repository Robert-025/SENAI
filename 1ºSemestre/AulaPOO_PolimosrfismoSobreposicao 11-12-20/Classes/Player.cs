using System;

namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;


        public virtual string Correr(){

            Console.WriteLine($"Correndo na velocidade 10");
            return "";
        }

        public virtual string Pular(){

            Console.WriteLine($"Pulando 5 pés");
            return "";
            
        }
    }
}