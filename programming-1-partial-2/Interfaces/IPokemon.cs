using programming_1_partial_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_1_partial_2.Interfaces
{
    internal interface IPokemon
    {
        string Name { get; set; }
        int Level { get; set; }
        int Health { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Speed { get; set; }
        int Experience { get; set; }
        int RequiredExperience { get; set; }

        void LevelUp();
        void GainExperience(int experience);
        void Heal();
        string ShowInfo();
        void AttackEnemy(Pokemon enemy);
    }
}
