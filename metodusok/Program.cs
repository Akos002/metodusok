namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koszonto();
            Console.WriteLine(Osszeadas(10,90));
        }

        static void Koszonto()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static int Osszeadas(int a, int b)
        {
            return a + b;
        }

    }
}