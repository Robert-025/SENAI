namespace AulaPOO_Encapsulamento.Classes
{
    public class MasterCard : Cartao
    {
        private int parcelas;
        public int Parcelas{ get; set; }

        //Métodos
        public string ComprarComDesconto(){
            if (valorCompra > 700)
            {
                return "Você tem 30% de desconto";
            }
            return "Você não tem desconto";
        }
    }
}