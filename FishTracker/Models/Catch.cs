using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTracker.Models
{
    public class Catch
    {
        public int CatchID { get; set; }
        public string Species { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int UserID { get; set; }
    }
}
