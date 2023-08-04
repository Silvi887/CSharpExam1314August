using System;

namespace BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int Maxgoals = int.MinValue;// nai-mnogo golove
            string NamePlayerMaxgoals = "";

            

            string NamePlayer= Console.ReadLine();
            while (NamePlayer != "END")
            {
                int countcurrentgoals=int.Parse(Console.ReadLine());

                if(countcurrentgoals > Maxgoals)
                {
                    Maxgoals = countcurrentgoals;
                    NamePlayerMaxgoals = NamePlayer;
                }

              

                if(countcurrentgoals >= 10)// 10 i pove4e gola
                {
                    break;
                }

                NamePlayer = Console.ReadLine();
            }

            //1 red
            Console.WriteLine($"{NamePlayerMaxgoals} is the best player!");


            //2 red
            if (Maxgoals >=3)// Napravil e het-trick
            {
                Console.WriteLine($"He has scored {Maxgoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {Maxgoals} goals.");
            }
        
        
        }
    }
}
