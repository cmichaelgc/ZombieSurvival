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

            if(userAnswer == "n")
            {
                Console.WriteLine("test");
            }
            Console.ReadLine();

            
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
