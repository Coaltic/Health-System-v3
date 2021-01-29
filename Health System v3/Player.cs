using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3
{
    class Player : Characters
    {
        public int damage;
        public int shield;


        public Player(string named)
        {
            health = 100;
            name = named;
            lives = 3;
            damage = 15;
            shield = 100;

            Console.WriteLine("New Player: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
        }

         public void ShowHud(Player player)
         {
            Console.WriteLine(name);
            Console.WriteLine("----------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Damage: " + damage);
         }

        public void RegenShield()
        {   if (shield <= 0) { shield = shield + 20; }
           
            shield = shield + (shield / 2);
            if (shield > 100) { shield = 100; }
            Console.WriteLine();
            Console.WriteLine("Your shield has regenerated");
            Console.WriteLine();
        }

        public void TakeDamage(int damage)
        {
            
            if ((shield - damage) <= 0) { health = (health - damage) + shield; shield = 0; }
            else { shield = shield - damage; }
            

            if (health <= 0)
            {
                lives = lives - 1;
                health = 100;
                shield = 100;
                Console.WriteLine();
                Console.WriteLine("Health has dropped below 0, current lives: " + lives);
                Console.WriteLine();
                if (lives <= 0)
                {
                    lives = 1;
                    Console.WriteLine();
                    Console.WriteLine("You're outta lives, but I'll give you another cause I like your vibe");
                    Console.WriteLine();
                }

            }
        }

        public void Heal()
        {
            health = health + (health / 2);
            Console.WriteLine();
            Console.WriteLine(health);
            Console.WriteLine();
            if (health >= 100)
            {
                health = 100;
                Console.WriteLine("Health has reached max, current health: " + health);
                Console.WriteLine();
            }
        }
    }
}
