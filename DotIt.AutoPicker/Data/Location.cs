using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data
{
    public partial class Location
    {
        public Location()
        {
            Itemlocation = new HashSet<Itemlocation>();
        }

        public int Locationid { get; set; }
        public string Locationtitle { get; set; }
        public string Locationdescription { get; set; }

        public virtual ICollection<Itemlocation> Itemlocation { get; set; }
    }
}
