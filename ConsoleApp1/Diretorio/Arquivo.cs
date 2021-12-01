using System;
using System.Configuration;
using System.IO;

namespace ConsoleApp1.Diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            Console.WriteLine("\n=== Lendo o arquivo =====\n" + arquivoComCaminho + "\n===========\n");
            if (File.Exists(arquivoComCaminho))
            {

                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";

            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.LerArquivos(numeroArquivo + 1);
            }

        }
    }
}
