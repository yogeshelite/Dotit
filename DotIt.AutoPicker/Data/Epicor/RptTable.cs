using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptTable
    {
        public RptTable()
        {
            RptCalcField = new HashSet<RptCalcField>();
            RptCriteriaMapping = new HashSet<RptCriteriaMapping>();
            RptExclude = new HashSet<RptExclude>();
            RptLinkTable = new HashSet<RptLinkTable>();
            RptWhereItem = new HashSet<RptWhereItem>();
        }

        public string RptDefId { get; set; }
        public string RptTableId { get; set; }
        public string SystemCode { get; set; }
        public string ZdataTableId { get; set; }
        public decimal SeqControl { get; set; }
        public string ParentRptTableId { get; set; }
        public bool PrimaryTable { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IsSystemTable { get; set; }
        public string QueryId { get; set; }
        public string EftheadCompany { get; set; }
        public int? EftheadUid { get; set; }

        public virtual RptDataDef RptDef { get; set; }
        public virtual ZdataTable ZdataTable { get; set; }
        public virtual ICollection<RptCalcField> RptCalcField { get; set; }
        public virtual ICollection<RptCriteriaMapping> RptCriteriaMapping { get; set; }
        public virtual ICollection<RptExclude> RptExclude { get; set; }
        public virtual ICollection<RptLinkTable> RptLinkTable { get; set; }
        public virtual ICollection<RptWhereItem> RptWhereItem { get; set; }
    }
}
