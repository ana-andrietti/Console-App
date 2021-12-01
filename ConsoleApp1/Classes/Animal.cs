namespace ConsoleApp1.Classes
{
    public abstract class Animal
    {
        public string Coleira;
        public string Pelo;
        public string Olhos;

        public abstract void Latir();

        public string Correr()
        {
            return "Animal está correndo";
        }

    }
}
