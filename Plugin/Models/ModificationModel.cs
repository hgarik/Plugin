using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin.Models
{
    public class ModificationModel
    {
        public int ResizeTo { get; set; }
        public int Blur { get; set; }
        public bool ConvertToGrayscale { get; set; }
    }
}
