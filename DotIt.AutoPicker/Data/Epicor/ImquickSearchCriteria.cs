using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImquickSearchCriteria
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
