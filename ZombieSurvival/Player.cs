using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Player
    {
        public enum WeaponType
        {
            Rustyshovel = 0,
            Revolver = 1,
            Hunkofwood = 2,
            Sturdybaseballbat = 3,
            Handgrenade = 4,
        }
        public WeaponType Weapon { get; set; }
        public int Health { get; set; }


        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Punch", 5 },
                {"Slash", 5 },
                {"Chop", 35 },
                {"Stab", 45 }
            };

        public Player(WeaponType weapon = WeaponType.Hunkofwood)
        {
            this.Weapon = weapon;
        }
        public WeaponType ChooseWeapon(int w)
        {
            switch (w)
            {
                case 0:
                    Console.WriteLine("The rusty shovel looks like it could work for you.");
                    return this.Weapon = WeaponType.Rustyshovel;
                case 1:
                    Console.WriteLine("You pick up the revolver, but it has no bullets....");
                    return this.Weapon = WeaponType.Revolver;
                case 2:
                    Console.WriteLine("You pick up a hunk of wood.");
                    return this.Weapon = WeaponType.Hunkofwood;
                case 3:
                    Console.WriteLine("The baseball bat seems like a good choice.");
                    return this.Weapon = WeaponType.Sturdybaseballbat;
                case 4:
                    Console.WriteLine("The hand grenade seems safe...");
                    return this.Weapon = WeaponType.Handgrenade;
                default:
                    Console.WriteLine("You could not decide what you wanted so you grab the Hunk of Wood! Good Luck!");
                    return this.Weapon = WeaponType.Hunkofwood;

            }
        }
        public void HelthDisplay()
        {
            Console.WriteLine("Your health is at {0}.", this.Health);
        }
        public void death()
        {
            Console.WriteLine("You are Dead.");
        }
    }
}
