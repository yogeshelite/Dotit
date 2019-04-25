using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.DotIt
{
    public partial class Item
    {
        public Item()
        {
            Itemcategory = new HashSet<Itemcategory>();
            Itemlocation = new HashSet<Itemlocation>();
            Price = new HashSet<Price>();
        }

        public int Itemid { get; set; }
        public string Itemtitle { get; set; }
        public string Itemdescription { get; set; }

        public virtual ICollection<Itemcategory> Itemcategory { get; set; }
        public virtual ICollection<Itemlocation> Itemlocation { get; set; }
        public virtual ICollection<Price> Price { get; set; }
    }
}
