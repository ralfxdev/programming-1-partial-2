using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_1_partial_2.Classes;

namespace programming_1_partial_2.Classes.ChildClasses
{
    internal class Squirtle : Pokemon
    {
        public Squirtle(string name, int level, int health, int attack, int defense, int speed, int experience, int requiredExperience) : base(name, level, health, attack, defense, speed, experience, requiredExperience)
        {
        }

        private void WaterGun(Pokemon enemy)
        {
            int damage = Attack * 2 - enemy.Defense;
            if (damage < 0)
            {
                damage = 0;
            }
            enemy.Health -= damage;
        }

        private void BubbleBeam(Pokemon enemy)
        {
            int damage = Attack - enemy.Defense;
            if (damage < 0)
            {
                damage = 0;
            }
            enemy.Health -= damage;
        }

        private void HydroPump(Pokemon enemy)
        {
            int damage = Attack * 3 - enemy.Defense;
            if (damage < 0)
            {
                damage = 0;
            }
            enemy.Health -= damage;
        }

        public override void AttackEnemy(Pokemon enemy)
        {
            Random random = new Random();
            int attack = random.Next(1, 4);
            switch (attack)
            {
                case 1:
                    WaterGun(enemy);
                    break;
                case 2:
                    BubbleBeam(enemy);
                    break;
                case 3:
                    HydroPump(enemy);
                    break;
            }
        }
    }
}
