using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReportStyleRule
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public string RptDefId { get; set; }
        public string RptTableId { get; set; }
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public string RuleBody { get; set; }
        public string Thumbnail { get; set; }
        public bool IsEnabled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ReportStyle ReportStyle { get; set; }
        public virtual RptDataDef RptDef { get; set; }
    }
}
