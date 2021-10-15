namespace AulaPOO_Heranca.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;
        public bool ValidarCNPJ(string documento){
            if (documento != "" || documento != " ")
            {
                return true;
            }
            return false;
        }
    }
}