namespace The_Scorpion_Swamp
{
    internal class LocationPath
    {
        private Location FirstLocation { get; set; }
        private Location LastLocation { get; set; }

        public int NumOfLocations { get; set; } = 0;

        public void AddLocation(Location location)
        {
            Location tempLocation = LastLocation;
            LastLocation = location;

            if (FirstLocation is null)
            {
                FirstLocation = LastLocation;
            }
            else
            {
                tempLocation.NextLocation = LastLocation;
            }
            NumOfLocations++;
        }

        public Location GetNextLocation()
        {
            Location output = FirstLocation;
            if (!(FirstLocation is null))
            {
                FirstLocation = FirstLocation.NextLocation;
                NumOfLocations--;
            }
            
            return output;
        }

        public bool IsNextLocationExists
        {
            get
            {
                return !(FirstLocation is null);
            }
        }
    }
}
