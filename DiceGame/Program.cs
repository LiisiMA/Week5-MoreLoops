using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskas rohkem, see ongi mängu võitja;
            //*täringuid vistakse 3 korda;
            //programm kuulutab võitjad 

            Random rnd = new Random();

            int cpuScore = 0;
            int userScore = 0;


            for (int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on voori võitnud!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on vooru võitnud");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            } 
            if(cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
            else
            {
                Console.WriteLine("Mängu võitis arvuti.");
            }
        }
    }
}
