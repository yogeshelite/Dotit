using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Obs10PkgUnit
    {
        public string Company { get; set; }
        public int PkgNum { get; set; }
        public int ParentPkgNum { get; set; }
        public string TranDocTypeId { get; set; }
        public string PkgCode { get; set; }
        public string PkgStatus { get; set; }
        public string PkgSerialNum { get; set; }
        public string RefNum { get; set; }
        public decimal PkgLength { get; set; }
        public decimal PkgWidth { get; set; }
        public decimal PkgHeight { get; set; }
        public string SizeUom { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public string Comment { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string LegalNumber { get; set; }
        public bool DocumentPrinted { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
