using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1.Funções
{
    class TelaUsuario
    {

        public static void Chamar()
        {


            Console.WriteLine("=====Cadastro de Usuário=====");

            while (true)
            {

                string mensagem = "Digite uma das opções abaixo:" +
                    "\n   0 - Sair do cadastro" +
                    "\n   1 - Para cadastrar Usuarios" +
                    "\n   2 - Para listar Usuarios";


                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o nome do Usuario: ");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Usuario: ");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Usuario: ");
                    usuario.CPF = Console.ReadLine();
                    usuario.Gravar();
                    Console.WriteLine("\nUsuario cadastrado com sucesso!\n\n");
                }
                else
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario c in Usuarios)
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
