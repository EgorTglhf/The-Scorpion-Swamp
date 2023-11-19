using System;

namespace The_Scorpion_Swamp
{
    static internal class LocationFactory
    {
        private const double CHANCE_SWAMP = 0.40;
        private const double CHANCE_THICKET = 0.35;
        private const double CHANCE_GLADE = 1 - (CHANCE_SWAMP + CHANCE_THICKET);

        private static readonly Random rnd;

        static LocationFactory()
        {
            rnd = new Random();
        }

        public static Location Create()
        {
            double roll = rnd.NextDouble();

            if (roll < CHANCE_SWAMP)
            {
                return CreateSwamp();
            }
            else if (roll < CHANCE_SWAMP + CHANCE_THICKET)
            {
                return CreateThicket();
            }
            else
            {
                return CreateGlade();
            }
        }

        public static LocationGlade CreateGlade() => new LocationGlade(GenerateEnemy());

        public static LocationSwamp CreateSwamp() => new LocationSwamp(GenerateEnemy());

        public static LocationThicket CreateThicket() => new LocationThicket(GenerateEnemy());

        public static Enemy GenerateEnemy()
        {
            return EnemyFactory.CreateEnemy();
        }
    }
}
