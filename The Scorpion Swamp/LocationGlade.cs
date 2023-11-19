namespace The_Scorpion_Swamp
{
    internal class LocationGlade : Location
    {
        private const int GLADE_HEALING_POWER = 1;

        public LocationGlade()
        {
            Type = TypeOfLocation.Glade;
        }

        public LocationGlade(Enemy enemy) : this()
        {
            SetEnemy(enemy);
        }

        override public void Effect(Character character)
        {
            if (EnemyOnLocation is null)
            {
                GameConsole.SlowWrite("There is quiet and peacefull on the glade.");
                character.GetHeal(GLADE_HEALING_POWER);
            }
        }
    }
}
