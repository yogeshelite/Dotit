using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptCriteriaMapping
    {
        public string Company { get; set; }
        public string RptDefId { get; set; }
        public string RptCriteriaSetId { get; set; }
        public string RptTableId { get; set; }
        public string ParameterId { get; set; }
        public int? PromptId { get; set; }
        public int? FilterId { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptCriteriaSet Rpt { get; set; }
        public virtual RptTable RptNavigation { get; set; }
    }
}
