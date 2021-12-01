namespace ConsoleApp1.Classes
{
    public class Cliente : Base
    {
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Cliente() { }

        public static string Teste;
    }
}
