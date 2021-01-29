using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3
{
    class Zombie : Enemy
    {
        public Zombie()
        {
            

            name = "Zombie";
            health = 50;
            enemyDamage = 15;

            Console.WriteLine();
            Console.WriteLine("New enemy " + name + " has appeared");
            Console.WriteLine();

            ShowHud();


            // i couldnt get this to work with the skeleton and im salty about it.



        }
    }
}
