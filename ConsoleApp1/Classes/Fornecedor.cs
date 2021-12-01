namespace ConsoleApp1.Classes
{
    public class Fornecedor : Base
    {
        public Fornecedor(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Fornecedor() { }
    }
}
