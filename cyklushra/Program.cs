 using System;

namespace cyklushra
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int vyber1;
            Console.Write("Vyber počáteční číslo");
            vyber1 = int.Parse(Console.ReadLine());

            int vyber2;
            Console.Write("Vyber konečné číslo číslo");
            vyber2 = int.Parse(Console.ReadLine());

            int Nahcislo = random.Next(vyber1, vyber2);
            int Tipcislo;
            bool neuhodl = true;





                Console.WriteLine("Hádání čísel");
                Console.WriteLine("----------------------");
                Console.WriteLine($"Myslím si číslo mezi {vyber1} a {vyber2}");

            while (neuhodl)
            {
                Console.WriteLine("Tipni si.");
                Tipcislo = int.Parse(Console.ReadLine());

                if (Tipcislo > Nahcislo)
                {
                    Console.WriteLine("To je moc");
                }
                else if (Tipcislo < Nahcislo)
                {
                    Console.WriteLine("To je málo");
                }
                else
                {
                    Console.WriteLine("Trefa!");
                    neuhodl = false;
                }
            }
           
        }  
        
    }
}
