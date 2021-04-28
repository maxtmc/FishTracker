using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTracker.Models
{
    public class Weather
    {
        public int WeatherID { get; set; }
        public int Temp { get; set; }
        public int BarPressure { get; set; }
        public string OvercastConditions { get; set; }
        public int TotalFishCaught { get; set; }
        public int UserID { get; set; }
    }
}
