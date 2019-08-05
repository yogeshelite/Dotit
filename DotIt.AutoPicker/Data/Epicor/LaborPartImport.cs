using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LaborPartImport
    {
        public string Company { get; set; }
        public int LaborHedSeq { get; set; }
        public int LaborDtlSeq { get; set; }
        public string PartNum { get; set; }
        public long ImportId { get; set; }
        public decimal PartQty { get; set; }
        public bool IntError { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ErrorLog { get; set; }
    }
}
