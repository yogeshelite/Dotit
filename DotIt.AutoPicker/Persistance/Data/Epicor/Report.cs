using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Report
    {
        public Report()
        {
            ReportDefaultStyle = new HashSet<ReportDefaultStyle>();
            ReportStyle = new HashSet<ReportStyle>();
            RptRule = new HashSet<RptRule>();
        }

        public string ReportId { get; set; }
        public string RptDescription { get; set; }
        public string AutoProgram { get; set; }
        public bool SystemRpt { get; set; }
        public string Cgccode { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Company { get; set; }
        public int CompanyVisibility { get; set; }

        public virtual ICollection<ReportDefaultStyle> ReportDefaultStyle { get; set; }
        public virtual ICollection<ReportStyle> ReportStyle { get; set; }
        public virtual ICollection<RptRule> RptRule { get; set; }
    }
}
