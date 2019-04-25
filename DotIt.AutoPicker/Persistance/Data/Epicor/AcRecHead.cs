using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcRecHead
    {
        public string Company { get; set; }
        public decimal RecHeadId { get; set; }
        public int InvoiceNum { get; set; }
        public DateTime? InvcDateTo { get; set; }
        public int CustNum { get; set; }
        public bool InclAdj { get; set; }
        public string RecStatus { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
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
