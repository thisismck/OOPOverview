namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Kofte kebapce = new Kofte();
            Corba corba = new Corba();
            Pilav pilav = new Pilav();
            Kazandibi kazandibi = new Kazandibi();
            Asci asci = new Asci();
            asci.Pisir(kebapce);
            asci.Pisir(corba);
            asci.Pisir(pilav);
            asci.Pisir(kazandibi);

        }
    }
}
