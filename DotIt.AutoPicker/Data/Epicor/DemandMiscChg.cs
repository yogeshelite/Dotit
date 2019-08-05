using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DemandMiscChg
    {
        public string Company { get; set; }
        public int DemandContractNum { get; set; }
        public int DemandHeadSeq { get; set; }
        public int DemandDtlSeq { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public string FreqCode { get; set; }
        public string Quoting { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
