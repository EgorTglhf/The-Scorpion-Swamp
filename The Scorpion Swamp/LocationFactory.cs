using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    static internal class LocationFactory
    {
        private static Random rnd;

        private static readonly double chanceSwamp = 0.40;
        private static readonly double chanceThicket = 0.35;
        private static readonly double chanceGlade = 1 - (chanceSwamp + chanceThicket);

        static LocationFactory()
        {
            rnd = new Random();
        }

        public static Location Create()
        {
            double roll = rnd.NextDouble();

            if (roll < chanceSwamp)
            {
                return CreateSwamp();
            }
            else if (roll < chanceSwamp + chanceThicket)
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
