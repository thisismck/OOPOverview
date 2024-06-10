namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Ekmek ekmek1 = new Ekmek();
            Ekmek ekmek2 = new Ekmek(2);
            Ekmek ekmek3 = new Ekmek(3, "Kepekli");
            Ekmek ekmek4 = new Ekmek("Kepekli");

            Report report = new Report("C:\\Users\\user\\Desktop\\report.xlsx");
        }
    }
}
