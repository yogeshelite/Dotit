using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data
{
    public partial class Price
    {
        public int Priceid { get; set; }
        public int Itemid { get; set; }
        public int Pricecatid { get; set; }
        public decimal Price1 { get; set; }

        public virtual Item Item { get; set; }
        public virtual Pricecategory Pricecat { get; set; }
    }
}
