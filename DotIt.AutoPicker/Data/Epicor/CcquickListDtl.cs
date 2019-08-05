using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CcquickListDtl
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public int ConNum { get; set; }
        public string Name { get; set; }
        public string ShipToNum { get; set; }
        public string PartNum { get; set; }
        public decimal OrderQty { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
