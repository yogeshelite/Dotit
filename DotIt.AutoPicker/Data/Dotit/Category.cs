using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class Category
    {
        public Category()
        {
            Itemcategory = new HashSet<Itemcategory>();
        }

        public int Categoryid { get; set; }
        public string Categorytitle { get; set; }
        public string Categorydescription { get; set; }

        public virtual ICollection<Itemcategory> Itemcategory { get; set; }
    }
}
