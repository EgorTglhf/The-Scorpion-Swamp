namespace The_Scorpion_Swamp
{
    internal class LocationGlade : Location
    {
        private const int GLADE_HEALING_POWER = 1;
        public LocationGlade()
        {
            Type = TypeOfLocation.Glade;
        }

        override public void Effect(Character character)
        {
            GameConsole.SlowWrite("There is quiet and peacefull on the glade.");
            character.GetHeal(GLADE_HEALING_POWER);
        }
    }
}
