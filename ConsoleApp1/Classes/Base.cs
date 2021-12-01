using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace ConsoleApp1.Classes
{
    public class Base : IPessoa
    {

        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Base() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCpf(string cpf) { this.CPF = cpf; }

        public virtual void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);


            StreamWriter r = new StreamWriter(diretorioComArquivo());
            r.WriteLine("nome;telefone;cpf;");
            foreach (Base b in dados)
            {
                var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                r.WriteLine(linha);
            }

            r.Close();

        }

        public List<Base> Ler()
        {

            var dados = new List<Base>();
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCpf(baseArquivo[2]);

                        dados.Add((Base)b);
                    }
                }
            }
            return dados;
        }

        private string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"] + this.GetType().Name + ".txt";
        }

        protected int Calcular()
        {
            return 1 + 2;
        }


        public virtual void Olhar()
        {
            int resultado = this.Calcular();
            Console.WriteLine("O usuário " + this.Nome + " está olhando para mim");
            Console.WriteLine(resultado);
        }

    }
}
