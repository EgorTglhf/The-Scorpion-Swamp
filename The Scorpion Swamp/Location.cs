namespace The_Scorpion_Swamp
{
    abstract internal class Location
    {
        public string Name => Type.ToString().ToLower();

        public TypeOfLocation Type { get; protected set; }

        public Enemy EnemyOnLocation { get; protected set; }

        public Location NextLocation { get; set; }

        virtual public void Effect(Character character) { }

        protected void SetEnemy(Enemy enemy)
        {
            EnemyOnLocation = enemy;
        }

        public void ShowInfo()
        {
            GameConsole.SlowWrite($"It is a {Name} in front of you." + (EnemyOnLocation is null ? "" : $" There is a {EnemyOnLocation.Name}!"));
        }
    }
}
