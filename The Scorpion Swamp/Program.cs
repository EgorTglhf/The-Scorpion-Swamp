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
            }

            GameConsole.CloseGame();
        }
    }
}
