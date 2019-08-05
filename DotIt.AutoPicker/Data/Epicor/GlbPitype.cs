using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPitype
    {
        public string BankAcctId { get; set; }
        public string Company { get; set; }
        public bool CustBankDtl { get; set; }
        public bool DefaultType { get; set; }
        public string Description { get; set; }
        public string EditypeCode { get; set; }
        public string GenType { get; set; }
        public string Glstage { get; set; }
        public string Initiation { get; set; }
        public string InitStatus { get; set; }
        public int Piscope { get; set; }
        public string Pitype { get; set; }
        public string ReconStatus { get; set; }
        public bool SupBankDtl { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPitype1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPitype { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
