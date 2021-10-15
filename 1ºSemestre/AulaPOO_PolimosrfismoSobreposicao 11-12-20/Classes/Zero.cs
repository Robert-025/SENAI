using System;

namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public class Zero : Player
    {
        private string sword;
        public string Sword{ get; set; }


        public override string Pular(){

            base.Pular();
            Console.WriteLine($"Upgrade Zero");

            Console.WriteLine($"Pulando 10 pés");
            return "";
            
        }
    }
}