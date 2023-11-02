namespace The_Scorpion_Swamp
{
    internal class LocationSwamp : Location
    {
        private const int LEECHES_ATTACK_DAMAGE = 1;

        public LocationSwamp()
        {
            Type = TypeOfLocation.Swamp;
        }

        override public void Effect(Character character) 
        {
            GameConsole.SlowWrite("Swamp leeches bit you.");
            character.GetDamage(LEECHES_ATTACK_DAMAGE);
        }
    }
}
