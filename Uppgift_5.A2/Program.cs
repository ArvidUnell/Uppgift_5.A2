using System;
namespace Uppgift_5_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anTal;

            Console.WriteLine("Hur många tal vill du skriva in?");

            while (true)
            {
                try
                {
                    anTal = int.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Det är inte ett giltigt tal. Försök igen.");
                }
            }

            int[] talArr = new int[anTal];

            Console.WriteLine($"Skriv in {anTal} heltal på varsin rad");

            for (int i = 0; i < anTal; i++)
            {
                while (true)
                {
                    try
                    {
                        talArr[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch 
                    {
                        Console.WriteLine("Det är inte ett giltigt tal! Försök igen.");
                    }
                }
            }

            Console.WriteLine("\nTalen du skrev in var:");
            foreach (int tal in talArr)
            {
                Console.WriteLine(tal);
            }

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}