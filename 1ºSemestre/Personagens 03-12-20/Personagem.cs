namespace Aula
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string iA;
        public int vida = 100;

        public int Atacar1(){

            return 100;
        }

        public int Atacar2(){

            return 20;
        }

        public int Defender(int ataque){
                 
            return this.vida = this.vida - ataque;
        }
    }
}