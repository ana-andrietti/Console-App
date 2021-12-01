using Calculo;
using ConsoleApp1.Diretorio;
using System;

namespace ConsoleApp1.Funções
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDOR = 6;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = " Olá, usuário! Bem vindo ao programa\n\n" +
                    "  Utilizando Programação Funcional\n\n" +
                    "\n   Digite uma das opções abaixo:" +
                    "\n   0 - Sair do programa" +
                    "\n   1 - Ler arquivos" +
                    "\n   2 - Tabuada" +
                    "\n   3 - Calcular média de alunos" +
                    "\n   4 - Cadastrar clientes" +
                    "\n   5 - Cadastrar usuários";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("\n============\n");
                    Arquivo.LerArquivos(1);
                    Console.WriteLine("\n============\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("\n============\n");
                    Console.WriteLine("Digite um número para ver sua tabuada: \n");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Tabuad(numero);
                    Console.WriteLine("\n============\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.CalcularMedia();
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    TelaUsuario.Chamar();
                }
                else if (valor == CADASTRAR_FORNECEDOR)
                {
                    TelaFornecedor.Chamar();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite novamente.");
                }
            }


        }
    }
}
