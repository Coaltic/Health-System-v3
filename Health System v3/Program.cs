using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3
{
    class Program
    {
        static public bool createCharacter = true;
        static bool gameActive;
        static Skeleton enemy;
        static Player player;
        static int loop = 0;



        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter Player Name");
            Console.WriteLine();

            string nameInput = Console.ReadLine();
            Console.WriteLine();


            Console.Clear();

            player = new Player(nameInput);
            Console.WriteLine();
            Console.ReadKey(true);
            Console.Clear();
            createCharacter = false;


            enemy = new Skeleton();
            Console.ReadKey(true);
            gameActive = true;
            GameActive();

            while (loop < 7)
            {
                Console.Clear();
                enemy = new Skeleton();
                Console.ReadKey(true);
                loop++;
                gameActive = true;
                GameActive();
            }

            Console.Clear();
            Console.WriteLine("You have defeated all the enemies");
            Console.WriteLine();
            Console.WriteLine("YOU WIN");
            Console.WriteLine();
            player.ShowHud(player);
            Console.ReadKey(true);


        }
        static void GameActive()
        { 
            while (gameActive == true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("MAKE YOUR CHOICE");
                Console.WriteLine("-----------------");
                Console.WriteLine("a - Attack");
                Console.WriteLine("b - Run Away");
                Console.WriteLine("c - debug menu");
                Console.WriteLine();


                string Input = Console.ReadLine();

                if (Input == "a")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You delt " + player.damage + " damage to the enemy");
                    Console.WriteLine();
                    enemy.TakeDamage(player.damage);
                    enemy.ShowHud();
                    Console.WriteLine();
                    player.ShowHud(player);
                    Console.ReadKey(true);

                    if (enemy.health > 0)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("The " + enemy.name + " attacks for " + enemy.enemyDamage + " damage");
                        Console.WriteLine();
                        player.TakeDamage(enemy.enemyDamage);
                        player.ShowHud(player);
                        Console.ReadKey(true);
                        
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Enemy has died");
                        player.RegenShield();
                        player.ShowHud(player);
                        gameActive = false;
                        Console.ReadKey(true);
                    }




                }
                else if (Input == "b")
                {
                    Console.Clear();
                    Console.WriteLine("You got away safely");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine();
                    Console.WriteLine("Make your decision");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("a - Heal");
                    Console.WriteLine("b - Regenerate Shield");
                    Console.WriteLine();
                    Input = Console.ReadLine();

                    if (Input == "a") { Console.Clear(); Console.WriteLine("You have healed yourself"); player.Heal(); player.ShowHud(player); Console.ReadKey(true); }
                    if (Input == "b") { Console.Clear(); Console.WriteLine("Your shield has been regenerated"); player.RegenShield(); player.ShowHud(player); Console.ReadKey(true); };
                    

                }
                else if (Input == "c")
                {
                    Console.Clear();
                    Console.WriteLine("Which would you like to try?");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();
                    Console.WriteLine("a - Heal");
                    Console.WriteLine("b - Regenerate Shield");
                    Console.WriteLine("c - Take Damage");
                    Console.WriteLine();
                    Console.WriteLine("All options will also display Show Hud");

                    Console.WriteLine();
                    Input = Console.ReadLine();

                    if (Input == "a") { Console.Clear(); player.TakeDamage(150); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("You have healed yourself"); Console.WriteLine(); player.Heal(); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("Setting your: health = -30"); player.health = (-30); Console.WriteLine(); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("You have healed yourself"); player.Heal(); Console.WriteLine(); player.ShowHud(player); Console.ReadKey(true); }
                    if (Input == "b") { Console.Clear(); player.TakeDamage(50); player.ShowHud(player); Console.WriteLine(); player.RegenShield(); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("Setting your: shield = -30"); player.shield = (-30); Console.WriteLine(); player.RegenShield(); Console.WriteLine(); player.ShowHud(player); Console.ReadKey(true); };
                    if (Input == "c") { Console.Clear(); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("You take 75 damage"); Console.WriteLine(); player.TakeDamage(75); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("You take 75 more damage"); Console.WriteLine(); player.TakeDamage(75); player.ShowHud(player); Console.WriteLine(); Console.WriteLine("You take -20 damage"); player.TakeDamage(-15); player.ShowHud(player); Console.ReadKey(true); }

                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    Console.WriteLine();
                }
            }

        }
       

    }
}
