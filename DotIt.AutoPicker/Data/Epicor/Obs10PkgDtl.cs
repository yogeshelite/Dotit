using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Obs10PkgDtl
    {
        public string Company { get; set; }
        public int PkgNum { get; set; }
        public int LineNum { get; set; }
        public string PartNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public decimal OurQty { get; set; }
        public string Ium { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string LotNum { get; set; }
        public string JobNum { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public string RefNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
