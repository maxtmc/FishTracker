using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FishTracker.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Title { get; set; }
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }

        public IFormFile ImageFile { get; set; }


    }
}
