using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTracker.Models
{
    public class Water
    {
        public int WaterID { get; set; }
        public int Temp { get; set; }
        public string Clarity { get; set; }
        public int TotalFishCaught { get; set; }
    }
}
