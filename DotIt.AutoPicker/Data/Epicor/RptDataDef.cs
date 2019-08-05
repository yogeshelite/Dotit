using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptDataDef
    {
        public RptDataDef()
        {
            ReportStyle = new HashSet<ReportStyle>();
            ReportStyleRule = new HashSet<ReportStyleRule>();
            RptCriteriaSet = new HashSet<RptCriteriaSet>();
            RptLiterals = new HashSet<RptLiterals>();
            RptRelation = new HashSet<RptRelation>();
            RptRule = new HashSet<RptRule>();
            RptStructuredOutputDef = new HashSet<RptStructuredOutputDef>();
            RptTable = new HashSet<RptTable>();
        }

        public string Company { get; set; }
        public string RptDefId { get; set; }
        public string RptDescription { get; set; }
        public bool SystemRpt { get; set; }
        public string RptTypeId { get; set; }
        public string DuplicateOf { get; set; }
        public string Cgccode { get; set; }
        public string PrimaryTable { get; set; }
        public string PrimaryKey1 { get; set; }
        public string PrimaryKey2 { get; set; }
        public bool UseMultipleCriteria { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CompanyVisibility { get; set; }

        public virtual ICollection<ReportStyle> ReportStyle { get; set; }
        public virtual ICollection<ReportStyleRule> ReportStyleRule { get; set; }
        public virtual ICollection<RptCriteriaSet> RptCriteriaSet { get; set; }
        public virtual ICollection<RptLiterals> RptLiterals { get; set; }
        public virtual ICollection<RptRelation> RptRelation { get; set; }
        public virtual ICollection<RptRule> RptRule { get; set; }
        public virtual ICollection<RptStructuredOutputDef> RptStructuredOutputDef { get; set; }
        public virtual ICollection<RptTable> RptTable { get; set; }
    }
}
