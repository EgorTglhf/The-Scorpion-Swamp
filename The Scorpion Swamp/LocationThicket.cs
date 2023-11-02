namespace The_Scorpion_Swamp
{
    internal class LocationThicket : Location
    {
        private const int THICKET_ATTACK_DAMAGE = 1;

        public LocationThicket()
        {
            Type = TypeOfLocation.Thicket;
        }

        override public void Effect(Character character)
        {
            GameConsole.SlowWrite("Thickets are thick and scratch you.");
            character.GetDamage(THICKET_ATTACK_DAMAGE);
        }
    }
}
