using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CcwhsAbc
    {
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string Plant { get; set; }
        public int Ccyear { get; set; }
        public int Ccmonth { get; set; }
        public bool FullPhysical { get; set; }
        public string Abccode { get; set; }
        public decimal QtyToSelect { get; set; }
        public decimal TotalSelected { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
