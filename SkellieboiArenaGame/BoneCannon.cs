using System;

namespace SkellieboiArenaGame
{
    public class BoneCannon
    {
        public string name;
        Random generator = new Random();


        public int chosenAttack;
        public string ChooseAttack(Skeleton target)
        {
            chosenAttack = generator.Next(3);

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

        public int weaponDamage(Skeleton target)
        {
            if (chosenAttack == 0)
            {
                return BoneZone();
            }

            if (chosenAttack == 1)
            {
                return BreakALeg(target);
            }

            if (chosenAttack == 2)
            {

                return RattleMeBones(target);
            }
            else
            {
                return 0;
            }

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