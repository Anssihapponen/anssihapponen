using System;

namespace MaatalousNäyttelyLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maatalousnäyttelyn lipun hinnan laskuri");
            int lipunHinta = 16;
            string varusmies;
            string opiskelija;
            string mtkJäsen;
            int ikä = 0;
            double alennus = 0;

            Console.Write("Oletko varusmies? Kyllä/Ei: ");
            varusmies = Console.ReadLine();

            if (varusmies.ToUpper() == "KYLLÄ")
            {
                alennus = 0.5;
                Console.WriteLine($"Lipun hinta on {lipunHinta - (lipunHinta * alennus)} e");
            }

            else
            {
                Console.Write("Oletko opiskelija? Kyllä/Ei: ");
                opiskelija = Console.ReadLine();
                Console.Write("Oletko MTk jäsen? Kyllä/Ei: ");
                mtkJäsen = Console.ReadLine();

                if (opiskelija.ToUpper() == "KYLLÄ" && mtkJäsen.ToUpper() == "KYLLÄ") 
                {
                    alennus = 0.6;
                    Console.WriteLine($"Lipun hinta on {lipunHinta - (lipunHinta * alennus)} e");
                }
                else if (opiskelija.ToUpper() == "KYLLÄ" && mtkJäsen.ToUpper() == "EI")
                {
                    alennus = 0.45;
                    Console.WriteLine($"Lipun hinta on {lipunHinta - (lipunHinta * alennus)}");
                }
                if (opiskelija.ToUpper() == "EI")
                {
                    Console.Write("Syötä ikä? ");
                    ikä = int.Parse(Console.ReadLine());

                    if (ikä < 7) 
                    {
                        alennus = 1;
                        Console.WriteLine("Lippusi on ilmainen!");
                    }
                    else if (ikä > 65 || ikä <= 15)
                    {
                        alennus = 0.50;
                        Console.WriteLine($"Lipun hinta on {lipunHinta - (lipunHinta * alennus)}");
                    }

                    else if (mtkJäsen.ToUpper() == "KYLLÄ")
                    {
                        alennus = 0.15;
                        Console.WriteLine($"Lipun hinta on {lipunHinta - (lipunHinta * alennus)}");
                    }
                    else
                    {
                        Console.WriteLine("Lipun hinta on 16e");
                    }
                }
                
                 
               
                



            }
            
            

            
            


        }
    }
}
