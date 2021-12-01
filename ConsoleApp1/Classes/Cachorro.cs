using System;

namespace ConsoleApp1.Classes
{
    public class Cachorro : Animal
    {
        public int Idade;

        private int idadePreDefinida = 1;

        public int Idade2
        {
            get
            {
                return idadePreDefinida;
            }
            set
            {
                idadePreDefinida = value;
            }
        }

        public override void Latir()
        {
            Console.WriteLine("Au");
        }
    }
}
