namespace The_Scorpion_Swamp
{
    abstract internal class Location
    {
        public string Name => Type.ToString().ToLower();

        public TypeOfLocation Type { get; protected set; }

        public Location NextLocation { get; set; }

        virtual public void Effect(Character character) { }

        public void ShowInfo()
        {
            GameConsole.SlowWrite($"It is a {Name} in front of you.");
        }
    }
}
