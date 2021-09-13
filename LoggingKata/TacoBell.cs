using System;
namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }

        public TacoBell(double latitude, double longitude, string name)
        {
            var location = new Point() { Latitude = latitude, Longitude = longitude };
            Location = location;
            Name = name;
        }

       
    }
}
