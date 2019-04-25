using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TwguinumDtl
    {
        public string Company { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string TranDocTypeId { get; set; }
        public string GroupId { get; set; }
        public string Prefix { get; set; }
        public int StartSeq { get; set; }
        public int EndSeq { get; set; }
        public int CurrentSeq { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
