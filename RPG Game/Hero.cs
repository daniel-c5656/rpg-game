using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Hero
    {
        private int health;
        private int damage;
        private int defence;
        private double critRate;
        public Hero(int health, int damage, int defence, double critRate)
        {
            this.health = health;
            this.damage = damage;
            this.defence = defence;
            this.critRate = critRate;
        }
        public void TakeDamage(int damage)
        {
            health -= damage;
        }
    }
}
