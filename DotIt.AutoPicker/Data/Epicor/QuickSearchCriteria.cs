using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuickSearchCriteria
    {
        public QuickSearchCriteria()
        {
            QuickSearchValueList = new HashSet<QuickSearchValueList>();
        }

        public string Company { get; set; }
        public string QuickSearchId { get; set; }
        public string GlbCompany { get; set; }
        public int Seq { get; set; }
        public string DataTableId { get; set; }
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string FieldLabel { get; set; }
        public string CompOp { get; set; }
        public string CriteriaType { get; set; }
        public bool IsReturnCol { get; set; }
        public string CriteriaValue { get; set; }
        public bool FilterOnNull { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual QuickSearch QuickSearch { get; set; }
        public virtual ICollection<QuickSearchValueList> QuickSearchValueList { get; set; }
    }
}
