using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrptDataDef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
