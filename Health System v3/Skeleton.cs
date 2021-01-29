using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3
{
    class Skeleton : Enemy
    { 
        
        
    
        public Skeleton()
        {
            //inBattle = true;

            name = "Skeleton";
            health = 60;
            enemyDamage = 50;

            Console.WriteLine();
            Console.WriteLine("New enemy " + name + " has appeared");
            Console.WriteLine();

            ShowHud();
            





        }

         /*public void ShowHud()
         {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + enemyDamage);
         }*/


    }
}
