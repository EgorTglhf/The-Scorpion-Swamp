namespace The_Scorpion_Swamp
{
    static internal class Battle
    {
        static public void Start(Character character1, Character character2)
        {
            GameConsole.SlowWrite($"Let the carnage begin! {character1.Name} и {character2.Name}.");
            while (character1.IsAlive && character2.IsAlive)
            {
                Round(character1, character2);
            }
            if (character1.IsAlive) GameConsole.SlowWrite("The battle is over..");
        }

        static private void Round(Character hero, Character enemy)
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
