using System;
using System.Threading;

namespace AulaPOOCelular.Classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;
        public bool ligacao;
        public bool mensagem;
        public bool desligado;

        //Métodos
        public void Ligar(string ligandoCelular, bool ligado){
            
            do
            {
                Console.WriteLine($"Deseja Ligar o celular? ");
                ligandoCelular = Console.ReadLine();
                
                if (ligandoCelular.ToUpper() == "S")
                {
                    ligado = true;

                    Console.WriteLine($"Ligando");

                    Thread.Sleep(1000);
                    Console.Clear();
                    
                }
                else if (ligandoCelular.ToUpper() == "N")
                {
                    ligado = false;
                }

            } while (ligandoCelular.ToUpper() != "S");
            
        }

        public bool Desligar(string desligandoCelular, bool desligando){    do
        {
            Console.WriteLine($"Deseja desligar o celular? ");
            desligandoCelular = Console.ReadLine(); 
            if (desligandoCelular.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine($"O celular está desligando.");
                Thread.Sleep(1000);

                break;
            }
            
        } while (desligandoCelular.ToUpper() != "N");
            
            return true;
        }
        public void FazerLigacao(bool ligacao){

                Console.WriteLine($"Digite o número que você deseja ligar:");Console.ReadLine();

                Console.WriteLine($". . . Não foi possível completar a ligação, tente mais tarde.");
                
        }
        public void EnviarMensagem(bool mensagem){
            
            Console.WriteLine($"Para quem você deseja enviar a mensagem?");
            Console.ReadLine();
            
            Console.Write($"Digite a mensagem: ");
            Console.ReadLine();
            
        }
    }
}