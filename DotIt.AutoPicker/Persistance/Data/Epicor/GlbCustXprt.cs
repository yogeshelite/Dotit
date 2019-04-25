using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbCustXprt
    {
        public string BasePartNum { get; set; }
        public string BaseRevisionNum { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangedBy { get; set; }
        public int ChangeTime { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string PartDescription { get; set; }
        public string PartNum { get; set; }
        public string SnlastUsedSeq { get; set; }
        public string Snmask { get; set; }
        public string SnmaskExample { get; set; }
        public string SnmaskPrefix { get; set; }
        public string SnmaskSuffix { get; set; }
        public bool Snoverride { get; set; }
        public string SourceDbrecid { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public string GlbCompany { get; set; }
        public int GlbCustNum { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbXpartNum { get; set; }
        public Guid GlbSysRowId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalCustXprt { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string EdicontainerType { get; set; }
        public string ProductionPartNum { get; set; }
        public bool ProductionPartNumIsValid { get; set; }
        public string ServicePartNum { get; set; }
        public bool ServicePartNumIsValid { get; set; }
    }
}
