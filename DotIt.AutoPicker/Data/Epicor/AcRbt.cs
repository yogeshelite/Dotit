using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRbt
    {
        public string Company { get; set; }
        public string BillingTypeCd { get; set; }
        public string Rbtdesc { get; set; }
        public string TermsCode { get; set; }
        public bool PrintStatements { get; set; }
        public string GroupCode { get; set; }
        public string CustCodeSuffix { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
