namespace bumbac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int vypsaneCislo = 1; vypsaneCislo <= 100; vypsaneCislo++)
            {
                if (vypsaneCislo % 5 == 0 && vypsaneCislo % 3 == 0)
                {
                    Console.WriteLine("BumBac");
                }
                else if (vypsaneCislo % 3 == 0)
                {
                    Console.WriteLine("Bum");
                }
                else if (vypsaneCislo % 5 == 0)
                {
                    Console.WriteLine("Bac");
                }
                else
                {
                    Console.WriteLine(vypsaneCislo);
                }
            }
        }
    }
}
