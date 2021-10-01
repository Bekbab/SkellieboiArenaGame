using System;

namespace SkellieboiArenaGame
{
    class Program
    {
        static void Main(string[] args)
        {


            Skeleton s1 = new Skeleton();
            Skeleton s2 = new Skeleton();

            Console.WriteLine("Name the first skeleton");
            s1.name = Console.ReadLine();

            Console.WriteLine("Name the second skeleton");
            s2.name = Console.ReadLine();

            Console.WriteLine($"Which skeleton do you wish to bet on? If they win you win, if they lose you lose. {s1.name} or {s2.name}");
            while (Skeleton.betGotten == false)
            {

                Skeleton.skellieBet = Console.ReadLine();

                if (Skeleton.skellieBet == s1.name)
                {
                    Skeleton.SkellieBetOn(s1);
                    Skeleton.betGotten = true;

                }
                else if (Skeleton.skellieBet == s2.name)
                {
                    Skeleton.SkellieBetOn(s2);
                    Skeleton.betGotten = true;
                }
                else
                {
                    Console.WriteLine("Name error. Try again.");
                }
            }

            while (Skeleton.bothAlive == true)
            {

                s1.Attack(s2);
                s2.Status();

                Console.ReadLine();

                s2.Attack(s1);
                s1.Status();

                Console.ReadLine();
            }



            Console.ReadLine();


        }
    }
}
