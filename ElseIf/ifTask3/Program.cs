using System;

namespace ifTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku positiivinen vai negatiivinen, sekä onko luku parillinen vai pariton");
            Console.Write("Syötä luku: ");

            int userInputNumber = int.Parse(Console.ReadLine());
            if (userInputNumber == 0)
                Console.WriteLine("Luku on nolla");
            else
                if (userInputNumber > 0)
                Console.WriteLine("Luku on positiivinen");
            else Console.WriteLine("Luku on negatiivinen");


            if (userInputNumber % 2 ==0)
                Console.WriteLine("Luku on parillinen");
            else Console.WriteLine("Luku on pariton");


        }
    }
}
