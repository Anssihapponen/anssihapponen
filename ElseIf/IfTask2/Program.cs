using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton");
            Console.Write("Syötä luku: ");

            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on parillinen");
            }

            else
            {
                Console.WriteLine($"Luku {userInputNumber} on pariton");
                    

                    
                    
            }

            


        }
    }
}
