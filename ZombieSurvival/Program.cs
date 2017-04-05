using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvival
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zombie Survival";
            MainAppTitle();
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("You wake up in a dark basement and are covered in blood.");
            Console.WriteLine("In the basement you find a flashlight, a healthy meal, and some weapons");
            Console.WriteLine("You obviously need the flashlight because it is dark, and the meal because you are starving.");
            Console.WriteLine("You can only cary one weapon. What do you Choose?\n" +
                               "\n" + 
                              "==================================================\n" +
                              "0: The Rusty Shovel\n" +
                              "1: A Revolver\n" +
                              "2: A hunk of Wood\n" +
                              "3: A Sturdy Baseball Bat\n" +
                              "4: A Handgrenade\n");
            int weaponType = int.Parse(Console.ReadLine());

            Console.Clear();
            Player player = new Player();
            player.ChooseWeapon(weaponType);

            Console.WriteLine("You are now prepared to leave. There is a door with some light shining from under it.\n" +
                "Would you like to go through the door? y/n");
            string userAnswer = Console.ReadLine();
            Console.WriteLine("====================================================");

            if (userAnswer == "n")
            {
                Console.WriteLine("After refusing to go through the door because you were too scared, a Zombie breaks in and devours you.");
                Console.ReadLine();
            }
            else if (userAnswer == "y")
                    {
                Console.Clear();
                Console.WriteLine("The door opens after a struggle, you take your first steps and are immediatly attacked by a Zombie.");

                Console.WriteLine("===================================================");
                Console.WriteLine("The battle begins and you are struggling to maintain any balance at all.\n" +
                    "You reach for your {0} and it falls out of your hands.\n" +
                    "The Zombie grabs for your throat, but you push it away and it falls to the ground.\n You have defeted the Zombie, and brush yourself off.\n You have to keep moving forward so you move to the next room.", player.Weapon);
                Console.WriteLine("======================================================");
                Console.WriteLine("There are two doors ahead. The Door on the left looks well kept, and the other seems to have been broken down\n" + 
                    "You have to keep moving forward.");
                Console.WriteLine("What door doo you choose? pick r/l");
                string userAnswer2 = Console.ReadLine();
                if (userAnswer2 == "l")
                {
                    Console.WriteLine("The door is locked... the zombie you thought was dead has bitten your leg. You are DEAD.");
                    Console.ReadLine();
                }
                else if (userAnswer2 == "r")
                {
                    Console.WriteLine("The Zombie you thought was dead attacks you, but you bust through the broken door,\n and the zombie is killed from falling debre that smashes its head.");
                    Console.ReadLine();
                }
            }
        }
        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"
                                                                     
           @@@@@@@@   @@@@@@   @@@@@@@@@@   @@@@@@@   @@@  @@@@@@@@  
           @@@@@@@@  @@@@@@@@  @@@@@@@@@@@  @@@@@@@@  @@@  @@@@@@@@  
                @@!  @@!  @@@  @@! @@! @@!  @@!  @@@  @@!  @@!       
               !@!   !@!  @!@  !@! !@! !@!  !@   @!@  !@!  !@!       
              @!!    @!@  !@!  @!! !!@ @!@  @!@!@!@   !!@  @!!!:!    
             !!!     !@!  !!!  !@!   ! !@!  !!!@!!!!  !!!  !!!!!:    
            !!:      !!:  !!!  !!:     !!:  !!:  !!!  !!:  !!:       
           :!:       :!:  !:!  :!:     :!:  :!:  !:!  :!:  :!:       
            :: ::::  ::::: ::  :::     ::    :: ::::   ::   :: ::::  
           : :: : :   : :  :    :      :    :: : ::   :    : :: ::   
                                                                     
                                                                             
   @@@@@@   @@@  @@@  @@@@@@@   @@@  @@@  @@@  @@@  @@@   @@@@@@   @@@       
  @@@@@@@   @@@  @@@  @@@@@@@@  @@@  @@@  @@@  @@@  @@@  @@@@@@@@  @@@       
  !@@       @@!  @@@  @@!  @@@  @@!  @@@  @@!  @@!  @@@  @@!  @@@  @@!       
  !@!       !@!  @!@  !@!  @!@  !@!  @!@  !@!  !@!  @!@  !@!  @!@  !@!       
  !!@@!!    @!@  !@!  @!@!!@!   @!@  !@!  !!@  @!@  !@!  @!@!@!@!  @!!       
   !!@!!!   !@!  !!!  !!@!@!    !@!  !!!  !!!  !@!  !!!  !!!@!!!!  !!!       
       !:!  !!:  !!!  !!: :!!   :!:  !!:  !!:  :!:  !!:  !!:  !!!  !!:       
      !:!   :!:  !:!  :!:  !:!   ::!!:!   :!:   ::!!:!   :!:  !:!   :!:      
  :::: ::   ::::: ::  ::   :::    ::::     ::    ::::    ::   :::   :: ::::  
  :: : :     : :  :    :   : :     :      :       :       :   : :  : :: : :  

              +-+-+-+-+-+ +-+-+-+ +-+-+-+ +-+-+ +-+-+-+-+ +-+-+-+
              |P|r|e|s|s| |A|n|y| |K|e|y| |T|o| |W|a|k|e| |U|p|!|
              +-+-+-+-+-+ +-+-+-+ +-+-+-+ +-+-+ +-+-+-+-+ +-+-+-+";
 


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
