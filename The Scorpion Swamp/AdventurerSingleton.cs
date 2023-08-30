using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    internal class AdventurerSingleton : Character
    {
        private const string BASE_NAME_ADVETURER = "The Adventurer";
        private const int BASE_HEALTH = 12;
        private const int BASE_DEXTERITY = 5;
        private const int BASE_ATTACK_DAMAGE = 2;

        private static AdventurerSingleton instance = null;

        private AdventurerSingleton() : base(BASE_NAME_ADVETURER, GenerateHealth(), GenerateDexterity(), BASE_ATTACK_DAMAGE)
        {
            ShowInfo();
        }

        public static AdventurerSingleton Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new AdventurerSingleton();
                }
                return instance;
            } 
        }

        public static void DeleteInstance()
        {
            instance = null;
        }

        private static int GenerateHealth()
        {
            return BASE_HEALTH + GameConsole.RollOfDice(2);
        }
        private static int GenerateDexterity()
        {
            return BASE_DEXTERITY + GameConsole.RollOfDice(1);
        }

        public override void Die()
        {
            base.Die();
            GameConsole.SlowWrite("Luck wasn't on your side.\nYour journey ends here...");
        }
    }
}
