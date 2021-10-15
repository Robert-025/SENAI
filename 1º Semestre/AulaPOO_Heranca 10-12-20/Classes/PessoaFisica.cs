namespace AulaPOO_Heranca.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento){
            if (documento != "" || documento != " ")
            {
                return true;
            }
            return false;
        }
    }
}