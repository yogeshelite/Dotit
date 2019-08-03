using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data
{
    public partial class Itemlocation
    {
        public int Itemlocid { get; set; }
        public int Itemid { get; set; }
        public int Locationid { get; set; }

        public virtual Item Item { get; set; }
        public virtual Location Location { get; set; }
    }
}
