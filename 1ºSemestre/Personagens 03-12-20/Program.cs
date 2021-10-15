using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaciando objeto

            Personagem jogador1 = new Personagem();
                jogador1.nome = "Robert";
                jogador1.idade = 17;
                jogador1.armadura = "Face-Shild";
                jogador1.iA = "Pure-Skill";

            Personagem jogador2 = new Personagem();
                jogador2.nome = "Tony Stark";
                jogador2.idade = 35;
                jogador2.armadura = "MK3";
                jogador2.iA = "Jarvis";
                jogador2.vida = 100;

                Console.Clear();
                Console.WriteLine($"Partida: {jogador1.nome} VS {jogador2.nome} ");
                Console.WriteLine($"{jogador1.nome} armadura: {jogador1.armadura} || {jogador2.nome} armadura: {jogador2.armadura}");
                Console.WriteLine($"{jogador1.nome} IA: {jogador1.iA} || {jogador2.nome} IA: {jogador2.iA}\n");

            // Iniciando uma luta

            int vidaDoJogador2 = jogador2.Defender(jogador1.Atacar2());

            Console.WriteLine($"O jogador 2 recebeu um ataque");
            

            if (vidaDoJogador2 <= 0)
            {
                Console.WriteLine($"O jogador morreu");
                
            }else
            {
                Console.WriteLine($"A vida do jogador 2 é: {jogador2.vida}");
                
            }
                
                
                


        }
    }
}
