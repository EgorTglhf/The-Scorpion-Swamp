using System;

namespace The_Scorpion_Swamp
{
    static internal class LocationPathFactory
    {
        private const int MIN_LENGTH = 8;
        private const int MAX_LENGTH = 12;

        private static readonly Random rnd;
        private static readonly int length;
        static LocationPathFactory()
        {
            rnd = new Random();
            length = rnd.Next(MIN_LENGTH, MAX_LENGTH);
        }
        public static LocationPath Create()
        {
            LocationPath Path = new LocationPath();
            for (int i = 0; i < length; i++)
            {
                Path.AddLocation(LocationFactory.Create());
            }
            return Path;
        }
    }
}
