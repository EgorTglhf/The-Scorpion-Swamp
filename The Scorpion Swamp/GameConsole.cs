using System;
using System.Threading;

namespace The_Scorpion_Swamp
{
    static internal class GameConsole
    {
        //Delay before printing a symbol. х10 delay for carriage tranfer and ending.
        private const int TIMEOUT_ONE_SYMBOL_MS = 5;
        private const int TIMEOUT_CARRIAGE_TRANSFER_MS = TIMEOUT_ONE_SYMBOL_MS * 10;
        private static readonly Random rnd;

        static GameConsole()
        {
            rnd = new Random();
        }

        public static void SlowWrite(string text)
        {
            foreach (char ch in text)
            {
                Console.Write(ch);
                Thread.Sleep(TIMEOUT_ONE_SYMBOL_MS);
            }
            Thread.Sleep(TIMEOUT_CARRIAGE_TRANSFER_MS);
            Console.WriteLine();
            Thread.Sleep(TIMEOUT_CARRIAGE_TRANSFER_MS);
        }

        public static void Welcome()
        {
            SlowWrite("Welcome to the mini game The Scorpion Swamp\n" +
                "You don't have to do anything, everything will happen on its own.\n" +
                "Your character will generate their attributes and will go through a random generated sequence of different locations,\n" +    
                "which can be filled with enemies!\n" +
                "All that is required of you - your luck.");
        }

        public static bool AskStartGame()
        {
            SlowWrite("Are you ready to start your journey? Press Enter if you are.");
            return Console.ReadKey(true).Key == ConsoleKey.Enter;
        }

        public static void CloseGame()
        {
            SlowWrite("For to close the game press Esc.");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
        }

        public static void StartGame()
        {
            SlowWrite("Today is a great day for fishing!\n" +
                "But alas, you've got an urgent task. You have to deliver the post to the nearest village.\n" +
                "Unfortunately for you your way lies through Scorpion Swamp - a forgotten by God place,\n" +
                "where dangerous creatures and misfits live.\n" +
                "You go on your journey at your own risk.");
        }

        public static void EndGoodMessage()
        {
            SlowWrite("It was the last location!\n" +
                "You finally come out of this damned swamp and see in front of you a small cute village where you were in such a hurry.\n" +
                "Congratulations! This time luck is on your side! You won!");
        }

        public static void EndBadMessage()
        {
            SlowWrite("Game Over.");
        }

        public static int RollOfDice(int amountDice)
        {
            int result = 0;
            for (int i = 0; i < amountDice; i++)
            {
                result += rnd.Next(1, 6);
            }
            return result;
        }
    }
}
