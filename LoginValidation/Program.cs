using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutaja tunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234";
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul võimalusel konsoolis kuvatakse "Vale kasutaja tunnus või salasõna. Proovi uuesti.";
            //kasutajal on kolm katset



            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    if(i == 3)
                    {
                        Console.WriteLine("Sisselogimine ebaõnnestus.");
                        break;
                    }
                    Console.WriteLine("Vale kasutajatunnus või parool.Proovi uuesti.");

                }



            }
        }
    }
}