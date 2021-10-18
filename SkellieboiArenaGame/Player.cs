using System;

namespace SkellieboiArenaGame
{

    public class Player
    {
        public static Skeleton s1 = new Skeleton();
        public static Skeleton s2 = new Skeleton();

        Skeleton betSkel;
        public bool betGotten = false;

        public string skellieBet;

        public static bool bothSkelsAlive = true;

        public static void chooseName()
        {
            Console.WriteLine("Name the first skeleton");
            s1.name = Console.ReadLine();

            Console.WriteLine("Name the second skeleton");
            s2.name = Console.ReadLine();
        }

        public Skeleton GetBet()
        {
            while (betGotten == false)
            {
                Console.WriteLine($"Which skeleton do you wish to bet on? If they win you win, if they lose you lose. {s1.name} or {s2.name}");

                skellieBet = Console.ReadLine();
                if (skellieBet == s1.name)
                {
                    betSkel = s1;
                    betGotten = true;
                }

                else if (skellieBet == s2.name)
                {
                    betSkel = s2;
                    betGotten = true;
                }
                else
                {
                    Console.WriteLine("Name error. Try again.");
                    Console.ReadLine();
                }
            }

            return betSkel;

        }

        public void SkellieBetOn(Skeleton target)
        {
            if (target.isAlive == false)
            {
                Console.WriteLine($"The skeleton you bet on ({target.name}) has died. You lost the bet.");
            }
            else if (bothSkelsAlive == false && target.isAlive == true)
            {
                Console.WriteLine($"The skeleton you bet on ({target.name}) has emerged victorious. You won the bet!");
            }


        }

    }
}