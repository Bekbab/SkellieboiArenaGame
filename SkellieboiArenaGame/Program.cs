using System;

namespace SkellieboiArenaGame
{
    class Program
    {

        static void Main(string[] args)
        {

            Player p1 = new Player();

            Player.chooseName();
            p1.SkellieBetOn(p1.GetBet());

            while (Player.bothSkelsAlive == true)
            {
                Player.s1.Attack(Player.s2);

                if (Player.s2.isAlive == true)
                {
                    Player.s2.Status();
                    Console.ReadLine();
                    Player.s2.Attack(Player.s1);
                    Player.s1.Status();
                }


                Console.ReadLine();
            }
            p1.SkellieBetOn(p1.GetBet());



            Console.ReadLine();


        }
    }
}
