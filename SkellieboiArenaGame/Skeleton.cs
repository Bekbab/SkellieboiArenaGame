using System;

namespace SkellieboiArenaGame
{
    public class Skeleton
    {
        private int hp = 200;

        public string name;

        public static bool bothAlive = true;

        public static bool betGotten = false;

        public static string skellieBet;


        public bool isAlive = true;

        BoneCannon bone = new BoneCannon();

        public bool legBroken = false;

        public bool rattled = false;

        public static void SkellieBetOn(Skeleton target)
        {
            if (target.isAlive == false)
            {
                Console.WriteLine($"The skeleton you bet on ({target}) has died. You lost the bet.");
            }
            else if (bothAlive == false && target.isAlive == true)
            {
                Console.WriteLine($"The skeleton you bet on ({target}) has emerged victorious. You won the bet!");
            }

        }
        public void TakeDamage(int amount)
        {

            hp -= amount;
            if (hp < 1)
            {
                Console.WriteLine($"{name} has died");
                isAlive = false;
                bothAlive = false;

            }
        }
        public void Attack(Skeleton target)
        {
            if (rattled == false)
            {
                string attackName = bone.ChooseAttack(target);

                int weaponDamage = bone.weaponDamage(target); //Funkar fortfarande inte

                if (legBroken)
                {
                    weaponDamage -= 5;
                }
                target.TakeDamage(weaponDamage);

                string damageString = weaponDamage + "";

                Console.WriteLine($"{name} used {attackName} on {target.name}. It deals {damageString} damage.");

            }
            rattled = false;

        }


        public void Status()
        {
            string hpString = hp + "";
            Console.WriteLine($"{name}'s HP is{hpString};");

            if (legBroken == true)
            {
                Console.WriteLine($"{name}'s legs are broken.");
            }
        }

    }
}