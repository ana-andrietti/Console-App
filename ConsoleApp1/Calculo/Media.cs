using System;
using System.Collections.Generic;

namespace Calculo
{
    class Media
    {
        public static void CalcularMedia()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("\nDigite as " + qtdNotas + " notas do aluno " + nome);

            List<int> notas = new List<int>();
            int totalNotas = 0;

            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("\nDigite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / qtdNotas;

            Console.WriteLine("A média do aluno " + nome + " é: " + media);
            Console.WriteLine("\nSuas notas são: \n");

            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }
    }
}
