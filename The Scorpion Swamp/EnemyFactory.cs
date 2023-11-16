using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    static internal class EnemyFactory
    {
        private static Random rnd;

        private static readonly double chanceWolf = 0.25;
        private static readonly double chanceBear = 0.15;
        private static readonly double chanceBandit = 0.20;
        private static readonly double chanceOrc = 0.15;
        private static readonly double chanceMinotaur = 0.5;
        private static readonly double chanceClear = 1 - (chanceWolf + chanceBear + chanceBandit + chanceOrc + chanceMinotaur);

        static EnemyFactory()
        {
            rnd = new Random();
        }

        public static Enemy CreateEnemy()
        {
            double roll = rnd.NextDouble();

            if (roll < chanceWolf)
            {
                return CreateWolf();
            }
            else if (roll < chanceWolf + chanceBear)
            {
                return CreateBear();
            }
            else if (roll < chanceWolf + chanceBear + chanceBandit)
            {
                return CreateBandit();
            }
            else if (roll < chanceWolf + chanceBear + chanceBandit + chanceOrc)
            {
                return CreateOrc();
            }
            else if (roll < chanceWolf + chanceBear + chanceBandit + chanceOrc + chanceMinotaur)
            {
                return CreateMinotaur();
            }
            else
            {
                return null;
            }
        }

        public static Enemy CreateMinotaur()
        {
            return new Enemy("Minotaur", rnd.Next(12, 15), rnd.Next(9, 12), 3);
        }
        public static Enemy CreateBandit()
        {
            return new Enemy("Bandit", rnd.Next(8, 11), rnd.Next(8, 10), 2);
        }
        public static Enemy CreateOrc()
        {
            return new Enemy("Orc", rnd.Next(12, 16), rnd.Next(5, 8), 3);
        }
        public static Enemy CreateBear()
        {
            return new Enemy("Bear", rnd.Next(13, 15), rnd.Next(5, 7), 3);
        }
        public static Enemy CreateWolf()
        {
            return new Enemy("Wolf", rnd.Next(5, 7), rnd.Next(6, 8), 2);
        }
    }
}
