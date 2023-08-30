using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    abstract internal class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Dexterity { get; protected set; }
        public int AttackDamage { get; protected set; }
        public bool IsAlive 
        { 
            get { return Health > 0; } 
        }

        public Character(string name, int hp, int dex, int ad)
        {
            Name = name;
            Health = hp;
            Dexterity = dex;
            AttackDamage = ad;
        }

        public virtual void Die()
        {
            GameConsole.SlowWrite($"{Name} died!");
        }

        public void Attack(Character attackedCharacter)
        {
            GameConsole.SlowWrite($"{Name} attacks and deals {AttackDamage} damage.");
            attackedCharacter.GetDamage(AttackDamage);
        }

        public void GetDamage(int dmg)
        {
            Health -= dmg;
            GameConsole.SlowWrite($"{Name} got {dmg} damage." + (Health > 0 ? $" {Name} has got {Health} health points." : ""));
            if (Health <= 0) { Die(); }
        }

        public void GetHeal(int hp)
        {
            Health += hp;
            GameConsole.SlowWrite($"{Name} was healed {hp} health points. Now {Name} has got {Health} health points.");
        }

        public void ShowInfo()
        {
            GameConsole.SlowWrite($"{Name} has got {Health} health points, their dexterity equals {Dexterity} and attack damage equals {AttackDamage}.");
        }
    }
}
