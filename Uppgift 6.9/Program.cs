using System.ComponentModel;

namespace Uppgift_6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till detta menyprogram!");
            Console.WriteLine("_________________________________");

            int nyckel = 0;

            while (nyckel != 3)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Är n ett primtal?");
                Console.WriteLine("2. Antalet primtal mindre än n");
                Console.WriteLine("3. Avsluta programmet.");
                string val = Console.ReadLine();
                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in ett heltal:");
                        int heltal = int.Parse(Console.ReadLine());

                        if (Primtal(heltal) == true)
                        {
                            Console.WriteLine($"{heltal} är ett primtal.");
                        }
                        else
                        {
                            Console.WriteLine($"{heltal} är inte ett primtal.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Skriv in ett heltal:");
                        int tal = int.Parse(Console.ReadLine());
                        int raknare = 0;

                        for (int i = tal - 1; i > 0; i--)
                        {
                            if (Primtal(i) == true)
                            {
                                raknare++;
                            }
                        }
                        Console.WriteLine($"Det är {raknare} antal primtal som är mindre än {tal}.");
                        break;
                    case "3":
                        Console.WriteLine("Programmet avslutas...");
                        nyckel = 3;
                        break;
                }
                Console.ReadKey();
            }
        }
        static bool Primtal(int tal)
        {
            if (tal < 2)
            {
                return true;
            }

            int namnare = 2;

            while (namnare * namnare <= tal)
            {
                if (tal % namnare == 0)
                {
                    return false;
                }
                namnare++;
            }
            return true;
        }
    }
}