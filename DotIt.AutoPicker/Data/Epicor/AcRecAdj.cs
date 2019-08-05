using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRecAdj
    {
        public string Company { get; set; }
        public decimal RecAdjId { get; set; }
        public decimal RecHeadId { get; set; }
        public decimal RatrxDtlId { get; set; }
        public string BadjRsnCd { get; set; }
        public decimal Amt { get; set; }
        public int InvoiceNum { get; set; }
        public decimal Raid { get; set; }
        public string Bcd { get; set; }
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
