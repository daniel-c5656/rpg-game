using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    namespace Enemies
    {
        internal class Enemy
        {
            private string name;
            private int damage;
            private int health;

            public Enemy(int damage, int health)
            {
                name = "Enemy";
                this.damage = damage;
                this.health = health;
            }
            public void Display()
            {
                Console.Write(name + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{health} HP");
                Console.ResetColor();
            }
            public void Attack(Hero player)
            {
                player.TakeDamage(damage);
            }
            public void TakeDamage(int damage)
            {
                health -= damage;
            }
        }
    }
}
