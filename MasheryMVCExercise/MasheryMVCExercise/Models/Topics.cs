using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasheryMVCExercise.Models
{
    public class Topics
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string imageUrl { get; set; }
        public string displayType { get; set; }
    }
}