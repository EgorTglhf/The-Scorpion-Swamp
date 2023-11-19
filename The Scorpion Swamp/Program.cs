using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameConsole.Welcome();

            if (GameConsole.AskStartGame())
            {
                Console.Clear();
                //Create hero and locations
                AdventurerSingleton Hero = AdventurerSingleton.Instance;
                LocationPath Path = LocationPathFactory.Create();

                //Opening
                GameConsole.StartGame();

                while (Path.IsNextLocationExists && Hero.IsAlive)
                {
                    Hero.Enter(Path.GetNextLocation());
                }

                if (Hero.IsAlive)
                {
                    GameConsole.EndGoodMessage();
                }
                else
                {
                    GameConsole.EndBadMessage();
                }
                AdventurerSingleton.DeleteInstance();
            }

            GameConsole.CloseGame();
        }
    }
}
