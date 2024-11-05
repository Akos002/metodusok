namespace metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koszonto();
            Console.WriteLine(Osszeadas(10,90));
            int a = 5;
            Console.WriteLine(Duplaz(a));
            int duplazott = Duplaz(a);
            Console.WriteLine(a);
            Console.WriteLine(duplazott);
            Console.WriteLine(Osszeg(10,7));
            int elso = 5;
            int masodik = 10;
            Csere(elso, masodik);
            Console.WriteLine(elso + " " + masodik);
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

        static int Duplaz(int szam)
        {
            return szam * 2;
        }

        static int Osszeg(int a, int b = 5)
        {
            return a + b;
        }

        static void Csere(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}