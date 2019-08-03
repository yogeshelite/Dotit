using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data
{
    public partial class Itemcategory
    {
        public int Itemcatid { get; set; }
        public int Itemid { get; set; }
        public int Categoryid { get; set; }

        public virtual Category Category { get; set; }
        public virtual Item Item { get; set; }
    }
}
