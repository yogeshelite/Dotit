using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ReportStyle
    {
        public ReportStyle()
        {
            ReportStyleImage = new HashSet<ReportStyleImage>();
            RptRule = new HashSet<RptRule>();
        }

        public string Company { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public string StyleDescription { get; set; }
        public string RptTypeId { get; set; }
        public string PrintProgram { get; set; }
        public string PrintProgramOptions { get; set; }
        public string RptDefId { get; set; }
        public string CompanyList { get; set; }
        public int ServerNum { get; set; }
        public string OutputLocation { get; set; }
        public string OutputEdi { get; set; }
        public bool SystemFlag { get; set; }
        public string Cgccode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string RptCriteriaSetId { get; set; }
        public string RptStructuredOutputDefId { get; set; }
        public bool StructuredOutputEnabled { get; set; }
        public bool RequireSubmissionId { get; set; }
        public bool AllowResetAfterSubmit { get; set; }

        public virtual Report Report { get; set; }
        public virtual RptDataDef RptDef { get; set; }
        public virtual ReportType RptType { get; set; }
        public virtual ReportStyleRule ReportStyleRule { get; set; }
        public virtual ICollection<ReportStyleImage> ReportStyleImage { get; set; }
        public virtual ICollection<RptRule> RptRule { get; set; }
    }
}
