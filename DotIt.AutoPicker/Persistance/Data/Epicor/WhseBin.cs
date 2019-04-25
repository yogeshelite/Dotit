using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WhseBin
    {
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string Description { get; set; }
        public bool NonNettable { get; set; }
        public string SizeId { get; set; }
        public string ZoneId { get; set; }
        public int BinSeq { get; set; }
        public string BinType { get; set; }
        public int CustNum { get; set; }
        public int VendorNum { get; set; }
        public string Aisle { get; set; }
        public string Face { get; set; }
        public int Elevation { get; set; }
        public decimal MaxFill { get; set; }
        public decimal PctFillable { get; set; }
        public bool InActive { get; set; }
        public bool Portable { get; set; }
        public bool Replenishable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SendToFsa { get; set; }
    }
}
