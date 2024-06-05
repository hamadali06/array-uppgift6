using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ttal separerade med det här teckmet *:");
            string inmatning = Console.ReadLine();
            string[] tal = inmatning.Split('*');
            int produkt = 1;
            foreach (string s in tal)
            {
                produkt *= int.Parse(s);
            }
            Console.WriteLine(produkt);
        }
    }
}
