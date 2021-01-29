using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3
{
    abstract class Enemy : Characters
    {

        public int enemyDamage;

        public Enemy()
        {
            

          

        }

        /*public void SpawnEnemy(int num)
        {
            if (num == 1)
            {
                Skeleton enemy = new Skeleton();
            }
            else if (num == 2)
            {
                Zombie enemy = new Zombie();
            }
        }*/

        public void TakeDamage(int damage)
        {
            health = health - damage;
            if (health < 0)
            {
                health = 0;
            }

        }

        public void ShowHud()
         {
            Console.WriteLine(name);
            Console.WriteLine("-----------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + enemyDamage);
         }
    }
}
