using System;

namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public class MegaMan : Player
    {
        private string buster;
        public string Buster{ get; set; }


        public override string Correr()
        {
            base.Correr();
            Console.WriteLine($"Upgrade MegaMan");
            
            Console.WriteLine($"Correndo na velocidade 20");
            return "";
        }


    }
}