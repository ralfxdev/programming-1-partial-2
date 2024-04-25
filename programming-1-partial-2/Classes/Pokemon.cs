using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_1_partial_2.Classes
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Experience { get; set; }
        public int RequiredExperience { get; set; }

        public Pokemon(string name, int level, int health, int attack, int defense, int speed, int experience, int requiredExperience)
        {
            Name = name;
            Level = level;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Experience = experience;
            RequiredExperience = requiredExperience;
        }

        public void LevelUp()
        {
            Level++;
            Health += 10;
            Attack += 5;
            Defense += 5;
            Speed += 5;
            RequiredExperience += 10;
        }

        public void GainExperience(int experience)
        {
            Experience += experience;
            if (Experience >= RequiredExperience)
            {
                LevelUp();
            }
        }

        public void Heal()
        {
            Health = 100;
        }

        public string ShowInfo()
        {
            return $"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nAttack: {Attack}\nDefense: {Defense}\nSpeed: {Speed}\nExperience: {Experience}\nRequired Experience: {RequiredExperience}";
        }

        public virtual void AttackEnemy(Pokemon enemy)
        {
            int damage = Attack - enemy.Defense;
            if (damage < 0)
            {
                damage = 0;
            }
            enemy.Health -= damage;
        }
    }
}
