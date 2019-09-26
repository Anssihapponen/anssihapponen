using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample");//tulostaa näytölle vakioviestin ReadWriteExample
            Console.Write("Your name:");//tulostaa näytölle vakioviestin
            //luetaan käyttäjän syöttämät merkit niin pitkään kunnes painetaan enter
            //sijoitetaan merkit merkkijonomuuttujaan userInput
            string userInput = Console.ReadLine();

            Console.WriteLine("-------------------------");

            //tulostaa näytölle vakioviestin ja muuttujan userInput arvon
            Console.WriteLine("Excuse me " + userInput + ", can you hear me?");
            Console.WriteLine("Excuse me {0}, can you hear me?", userInput);
            Console.WriteLine($"Excuse me {userInput}, can you hear me?");
            //Tulostuksen muotoilu ja muuttujien käyttö
            //Tulostuksen yhteydessä $-merkin avulla = String.Format()
            
        }
    }
}
