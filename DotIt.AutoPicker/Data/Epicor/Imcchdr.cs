using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imcchdr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string Plant { get; set; }
        public int Ccyear { get; set; }
        public int Ccmonth { get; set; }
        public bool FullPhysical { get; set; }
        public int CycleSeq { get; set; }
        public DateTime? CycleDate { get; set; }
        public int CycleStatus { get; set; }
        public DateTime? TagGenDate { get; set; }
        public DateTime? SeqStartDate { get; set; }
        public int TimeSeqStarted { get; set; }
        public DateTime? CompleteDate { get; set; }
        public int CompleteTime { get; set; }
        public bool AdjustPosted { get; set; }
        public int SheetOrTag { get; set; }
        public decimal TotalParts { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IncludeNonNettable { get; set; }
        public int TotalPcidselected { get; set; }
        public bool NestedPcid { get; set; }
    }
}
