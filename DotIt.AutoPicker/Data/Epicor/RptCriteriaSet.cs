using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptCriteriaSet
    {
        public RptCriteriaSet()
        {
            RptCriteriaFilter = new HashSet<RptCriteriaFilter>();
            RptCriteriaMapping = new HashSet<RptCriteriaMapping>();
            RptCriteriaPrompt = new HashSet<RptCriteriaPrompt>();
        }

        public string Company { get; set; }
        public string RptDefId { get; set; }
        public string RptCriteriaSetId { get; set; }
        public string Description { get; set; }
        public bool SystemFlag { get; set; }
        public bool IsDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptDataDef RptDef { get; set; }
        public virtual ICollection<RptCriteriaFilter> RptCriteriaFilter { get; set; }
        public virtual ICollection<RptCriteriaMapping> RptCriteriaMapping { get; set; }
        public virtual ICollection<RptCriteriaPrompt> RptCriteriaPrompt { get; set; }
    }
}
