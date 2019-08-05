using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCcserviceRecon
    {
        public string Company { get; set; }
        public int ServiceReconId { get; set; }
        public string VendorId { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string TermsCode { get; set; }
        public string GroupId { get; set; }
        public string Status { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
