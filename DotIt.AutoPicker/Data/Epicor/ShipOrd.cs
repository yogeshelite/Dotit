using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ShipOrd
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int OrderNum { get; set; }
        public decimal ShippedAmt { get; set; }
        public decimal InvoicedAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
