namespace AulaPOO_Interface.Classes
{
    public interface ICarrinho
    {
        //CRUD

        //Create - Criar
            void Cadastrar(Produto produto);
        //Read - Ler
            void Listar();
        //Update - Alterar
            void Alterar(int _codigo, Produto produto);
        //Delete - Excluir
            void Deletar(Produto produto);
    }
}