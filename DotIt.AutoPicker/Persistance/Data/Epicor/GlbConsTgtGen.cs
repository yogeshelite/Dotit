using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbConsTgtGen
    {
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public int GlbGenId { get; set; }
        public int GenId { get; set; }
        public string ConsDefId { get; set; }
        public string Description { get; set; }
        public string GenStatus { get; set; }
        public string TgtCompany { get; set; }
        public string TgtBook { get; set; }
        public string TargetCoa { get; set; }
        public string IntermediateBookId { get; set; }
        public bool ImmediateTrans { get; set; }
        public string CurrencyCode { get; set; }
        public bool RemoteParent { get; set; }
        public bool VantageDb { get; set; }
        public string OutputFile { get; set; }
        public string RemoteAcct { get; set; }
        public string ConsolidationType { get; set; }
        public string AdjustMode { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string EntryMode { get; set; }
    }
}
