using System;

namespace ifTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen");
            Console.Write("Syötä 1. luku: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2. Luku: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Syötä 3. luku: ");
            int z = int.Parse(Console.ReadLine());

            if (x > y)
                if (y > z)
                    Console.WriteLine($"{z},{y},{x}");
                else if (x > z)
                    Console.WriteLine($"{y},{z},{x}");
                else Console.WriteLine($"{y},{x},{z}");
            if (y > x)
                if (x > z)
                    Console.WriteLine($"{z},{x},{y}");
                else if (y > z)
                    Console.WriteLine($"{x},{z},{y}");
                else Console.WriteLine($"{x},{y},{z}");
            
                

            
            
            
            
            


        }
    }
}
