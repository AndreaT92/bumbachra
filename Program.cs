namespace bumbac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int vypsaneCislo = 1; vypsaneCislo <= 100; vypsaneCislo++)
            {
                string vystup = string.Empty; 
                
                
                if (vypsaneCislo % 3 == 0)
                {
                    vystup = "Bum";
                }
                if (vypsaneCislo % 5 == 0)
                {
                    vystup += "Bac";
                }
                if (vystup == string.Empty) 
                {
                    vystup = vypsaneCislo.ToString();
                }
                Console.WriteLine(vystup);
            }
        }
    }
}
