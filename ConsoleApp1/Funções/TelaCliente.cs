using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1.Funções
{
    class TelaCliente
    {

        public static void Chamar()
        {


            Console.WriteLine("=====Cadastro de Clientes=====");

            while (true)
            {

                string mensagem = "Digite uma das opções abaixo:" +
                    "\n   0 - Sair do cadastro" +
                    "\n   1 - Para cadastrar clientes" +
                    "\n   2 - Para listar clientes";


                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var cliente = new Cliente();

                    Console.WriteLine("Digite o nome do cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do cliente: ");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do cliente: ");
                    cliente.CPF = Console.ReadLine();
                    cliente.Gravar();
                    Console.WriteLine("\nCliente cadastrado com sucesso!\n\n");
                }
                else
                {
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
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
