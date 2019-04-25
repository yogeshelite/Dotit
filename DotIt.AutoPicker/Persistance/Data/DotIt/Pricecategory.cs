using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.DotIt
{
    public partial class Pricecategory
    {
        public Pricecategory()
        {
            Price = new HashSet<Price>();
        }

        public int Pricecatid { get; set; }
        public string Pricecattitle { get; set; }
        public string Pricecatdescription { get; set; }

        public virtual ICollection<Price> Price { get; set; }
    }
}
