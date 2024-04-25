using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_1_partial_2.Classes
{
    internal delegate void AttackHandler(Pokemon attacker, Pokemon target, int damage);

    internal interface ICurable
    {
        void Heal();
    }

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

        public event EventHandler ExperienceChanged;
        public event AttackHandler Attacked;

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
            OnExperienceChanged();
        }

        protected virtual void OnExperienceChanged()
        {
            ExperienceChanged?.Invoke(this, EventArgs.Empty);
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
            OnAttacked(this, enemy, damage);
        }

        protected virtual void OnAttacked(Pokemon attacker, Pokemon target, int damage)
        {
            Attacked?.Invoke(attacker, target, damage);
        }

        // Indexador para acceder a los atributos del Pokémon por su nombre
        public int this[string attributeName]
        {
            get
            {
                switch (attributeName.ToLower())
                {
                    case "level":
                        return Level;
                    case "health":
                        return Health;
                    case "attack":
                        return Attack;
                    case "defense":
                        return Defense;
                    case "speed":
                        return Speed;
                    case "experience":
                        return Experience;
                    case "requiredexperience":
                        return RequiredExperience;
                    default:
                        throw new ArgumentException("Invalid attribute name");
                }
            }
            set
            {
                switch (attributeName.ToLower())
                {
                    case "level":
                        Level = value;
                        break;
                    case "health":
                        Health = value;
                        break;
                    case "attack":
                        Attack = value;
                        break;
                    case "defense":
                        Defense = value;
                        break;
                    case "speed":
                        Speed = value;
                        break;
                    case "experience":
                        Experience = value;
                        break;
                    case "requiredexperience":
                        RequiredExperience = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid attribute name");
                }
            }
        }
    }
}