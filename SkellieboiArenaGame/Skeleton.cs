using System;

namespace SkellieboiArenaGame
{
    public class Skeleton
    {
        private int hp = 50;

        public string name;
        public bool isAlive = true;

        BoneCannon bone = new BoneCannon();

        public bool legBroken = false;

        public bool rattled = false;


        public void TakeDamage(int amount)
        {

            hp -= amount;
            if (hp < 1)
            {
                Console.WriteLine($"{name} has died");
                isAlive = false;
                Player.bothSkelsAlive = false;
            }
        }
        public void Attack(Skeleton target)
        {
            if (rattled == false)
            {
                string attackName = bone.ChooseAttack(target);

                int weaponDamage = bone.weaponDamage(target);

                if (legBroken)
                {
                    weaponDamage -= 5;
                }

                string damageString = weaponDamage + "";

                Console.WriteLine($"{name} used {attackName} on {target.name}. It deals {damageString} damage.");

                target.TakeDamage(weaponDamage);

            }

            else
            {
                Console.WriteLine($"{name} is too rattled to fight");
                rattled = false;
            }

        }


        public void Status()
        {
            string hpString = hp + "";
            Console.WriteLine($"{name}'s HP is {hpString};");

            if (legBroken == true)
            {
                Console.WriteLine($"{name}'s legs are broken.");
            }
            if (rattled == true)
            {
                Console.WriteLine($"{name} is rattled.");
            }

        }

    }
}