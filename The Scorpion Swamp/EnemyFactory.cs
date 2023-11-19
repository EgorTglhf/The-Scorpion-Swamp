using System;

namespace The_Scorpion_Swamp
{
    static internal class EnemyFactory
    {
        private const double CHANCE_WOLF = 0.25;
        private const double CHANCE_BEAR = 0.15;
        private const double CHANCE_BANDIT = 0.20;
        private const double CHANCE_ORC = 0.15;
        private const double CHANCE_MINOTAUR = 0.15;
        private const double CHANCE_CLEAR = 1 - (CHANCE_WOLF + CHANCE_BEAR + CHANCE_BANDIT + CHANCE_ORC + CHANCE_MINOTAUR);

        private const string MINOTAUR_NAME = "Minotaur";
        private const int MINOTAUR_HP_MIN = 12;
        private const int MINOTAUR_HP_MAX = 15;
        private const int MINOTAUR_DEX_MIN = 9;
        private const int MINOTAUR_DEX_MAX = 12;
        private const int MINOTAUR_AD = 3;

        private const string BANDIT_NAME = "Bandit";
        private const int BANDIT_HP_MIN = 8;
        private const int BANDIT_HP_MAX = 11;
        private const int BANDIT_DEX_MIN = 8;
        private const int BANDIT_DEX_MAX = 10;
        private const int BANDIT_AD = 2;

        private const string ORC_NAME = "Orc";
        private const int ORC_HP_MIN = 12;
        private const int ORC_HP_MAX = 16;
        private const int ORC_DEX_MIN = 5;
        private const int ORC_DEX_MAX = 8;
        private const int ORC_AD = 3;

        private const string BEAR_NAME = "Bear";
        private const int BEAR_HP_MIN = 12;
        private const int BEAR_HP_MAX = 16;
        private const int BEAR_DEX_MIN = 5;
        private const int BEAR_DEX_MAX = 8;
        private const int BEAR_AD = 3;

        private const string WOLF_NAME = "Wolf";
        private const int WOLF_HP_MIN = 12;
        private const int WOLF_HP_MAX = 16;
        private const int WOLF_DEX_MIN = 5;
        private const int WOLF_DEX_MAX = 8;
        private const int WOLF_AD = 3;

        private static readonly Random rnd;

        static EnemyFactory()
        {
            rnd = new Random();
        }

        public static Enemy CreateEnemy()
        {
            double roll = rnd.NextDouble();

            if (roll < CHANCE_WOLF)
            {
                return CreateWolf();
            }
            else if (roll < CHANCE_WOLF + CHANCE_BEAR)
            {
                return CreateBear();
            }
            else if (roll < CHANCE_WOLF + CHANCE_BEAR + CHANCE_BANDIT)
            {
                return CreateBandit();
            }
            else if (roll < CHANCE_WOLF + CHANCE_BEAR + CHANCE_BANDIT + CHANCE_ORC)
            {
                return CreateOrc();
            }
            else if (roll < CHANCE_WOLF + CHANCE_BEAR + CHANCE_BANDIT + CHANCE_ORC + CHANCE_MINOTAUR)
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
            return new Enemy(MINOTAUR_NAME, 
                rnd.Next(MINOTAUR_HP_MIN, MINOTAUR_HP_MAX), 
                rnd.Next(MINOTAUR_DEX_MIN, MINOTAUR_DEX_MAX), 
                MINOTAUR_AD);
        }
        public static Enemy CreateBandit()
        {
            return new Enemy(BANDIT_NAME, 
                rnd.Next(BANDIT_HP_MIN, BANDIT_HP_MAX), 
                rnd.Next(BANDIT_DEX_MIN, BANDIT_DEX_MAX), 
                BANDIT_AD);
        }
        public static Enemy CreateOrc()
        {
            return new Enemy(ORC_NAME, 
                rnd.Next(ORC_HP_MIN, ORC_HP_MAX), 
                rnd.Next(ORC_DEX_MIN, ORC_DEX_MAX),
                ORC_AD);
        }
        public static Enemy CreateBear()
        {
            return new Enemy(BEAR_NAME, 
                rnd.Next(BEAR_HP_MIN, BEAR_HP_MAX), 
                rnd.Next(BEAR_DEX_MIN, BEAR_DEX_MAX), 
                BEAR_AD);
        }
        public static Enemy CreateWolf()
        {
            return new Enemy(WOLF_NAME, 
                rnd.Next(WOLF_HP_MIN, WOLF_HP_MAX), 
                rnd.Next(WOLF_DEX_MIN, WOLF_DEX_MAX),
                WOLF_AD);
        }
    }
}
