using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    static internal class Battle
    {
        static public void Start(AdventurerSingleton hero, Enemy enemy)
        {
            GameConsole.SlowWrite($"Let the carnage begin! {hero.Name} и {enemy.Name}.");
            while (hero.IsAlive && enemy.IsAlive)
            {
                Round(hero, enemy);
            }
            if (hero.IsAlive) GameConsole.SlowWrite("The battle is over..");
        }

        static private void Round(AdventurerSingleton hero, Enemy enemy)
        {

            int heroStrentgh = hero.Dexterity + GameConsole.RollOfDice(2);
            int enemyStrength = enemy.Dexterity + GameConsole.RollOfDice(2);

            if (heroStrentgh > enemyStrength)
            {
                hero.Attack(enemy);
            }
            else if (heroStrentgh < enemyStrength)
            {
                enemy.Attack(hero);
            }
            else
            {
                GameConsole.SlowWrite("They fight for life and death!");
            }
        }
    }
}
