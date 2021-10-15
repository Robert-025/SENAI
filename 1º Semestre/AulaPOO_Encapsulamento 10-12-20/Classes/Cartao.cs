namespace AulaPOO_Encapsulamento.Classes
{
    public class Cartao
    {    
    private string nomeTitular;
    public string NomeTitular{ get; set;}


    private string numero;
    public string Numero{ get; set; }


    private string bandeira;
    public string Bandeira{ get; set; }


    protected string token = "qwertyui";
    public string Token{ get;set; }


    private string cvv;
    public string Cvv{ get; set; }


    protected float limite = 5000;
    public float Limite{ get; }


    protected float valorCompra;
    public float ValorCompra{ get; set; }


    public string produto;

     //Métodos

    public string RegistrarCompra(bool valildado){
        if (valorCompra > 0)
        {
            valildado = true;
            return "Compra registrada";
        }else{
            valildado = false;
            return "Algo está errado. Tente novamente";            
        }
        
     }
    }
}