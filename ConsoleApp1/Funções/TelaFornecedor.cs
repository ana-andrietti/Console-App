using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1.Funções
{
    class TelaFornecedor
    {

        public static void Chamar()
        {


            Console.WriteLine("=====Cadastro de Fornecedors=====");

            while (true)
            {

                string mensagem = "Digite uma das opções abaixo:" +
                    "\n   0 - Sair do cadastro" +
                    "\n   1 - Para cadastrar Fornecedors" +
                    "\n   2 - Para listar Fornecedors";


                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Digite o nome do Fornecedor: ");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Fornecedor: ");
                    fornecedor.CPF = Console.ReadLine();
                    fornecedor.Gravar();
                    Console.WriteLine("\nFornecedor cadastrado com sucesso!\n\n");
                }
                else
                {
                    var Fornecedors = new Fornecedor().Ler();
                    foreach (Fornecedor c in Fornecedors)
                    {
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);
                    }
                }
            }
        }
    }
}
