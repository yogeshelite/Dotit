using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcValueHead
    {
        public PcValueHead()
        {
            PcValueInputLayerHeader = new HashSet<PcValueInputLayerHeader>();
        }

        public string Company { get; set; }
        public int GroupSeq { get; set; }
        public int HeadNum { get; set; }
        public string StructTag { get; set; }
        public string ConfigId { get; set; }
        public int RevolvingSeq { get; set; }
        public string ForeignTableName { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string SourceTableName { get; set; }
        public Guid SourceSysRowId { get; set; }
        public string ConfigType { get; set; }
        public int ConfigVersion { get; set; }
        public string DisplayTag { get; set; }
        public string RuleTag { get; set; }
        public bool ExtConfig { get; set; }
        public string ExtCompany { get; set; }
        public bool AllowRecordCreation { get; set; }
        public bool AllowPricing { get; set; }
        public bool PromptForConfig { get; set; }
        public bool InSmartString { get; set; }
        public bool DisplaySummary { get; set; }
        public bool AllowReconfig { get; set; }
        public bool IsMainForeign { get; set; }
        public string NewPartNum { get; set; }
        public string NewSmartString { get; set; }
        public bool Sivalues { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<PcValueInputLayerHeader> PcValueInputLayerHeader { get; set; }
    }
}
