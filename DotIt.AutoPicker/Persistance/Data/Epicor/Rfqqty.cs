using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Rfqqty
    {
        public string Company { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public int QtyNum { get; set; }
        public decimal Quantity { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
