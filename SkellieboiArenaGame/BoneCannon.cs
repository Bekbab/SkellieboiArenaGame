using System;

namespace SkellieboiArenaGame
{
    public class BoneCannon
    {
        public string name;
        Random generator = new Random();

        int damage;

        public int chosenAttack;
        public string ChooseAttack(Skeleton target)
        {
            int chosenAttack = generator.Next(3);

            if (chosenAttack == 0)
            {

                BoneZone();
                return "Bone Zone";
            }

            if (chosenAttack == 1)
            {

                BreakALeg(target);
                return "Break A Leg";
            }
            if (chosenAttack == 2)
            {

                RattleMeBones(target);
                return "Rattle Me Bones";
            }

            else
            {
                return null;
            }

        }

        public int weaponDamage(Skeleton target) //funkar inte
        {
            if (chosenAttack == 1)
            {
                int damage = BoneZone();
            }

            if (chosenAttack == 1)
            {
                int damage = BreakALeg(target);
            }

            if (chosenAttack == 2)
            {

                int damage = RattleMeBones(target);

            }

            return damage;
        }

        public int BoneZone()
        {
            return 15;
        }

        public int BreakALeg(Skeleton target)
        {
            target.legBroken = true;
            return 5;
        }

        public int RattleMeBones(Skeleton target)
        {
            target.rattled = true;
            return 5;
        }






    }
}