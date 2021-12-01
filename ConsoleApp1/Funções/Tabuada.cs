using System;

namespace ConsoleApp1.Funções
{
    class Tabuada
    {
        public static void Tabuad(int numero)
        {
            Console.WriteLine("====== Cálculo da tabuada ======");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            Console.WriteLine("============");
        }
    }
}
