using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcBschDtl
    {
        public string Company { get; set; }
        public decimal BschDtlId { get; set; }
        public decimal BschHeadId { get; set; }
        public string Bcd { get; set; }
        public string ParentBcd { get; set; }
        public int NbrOfChrgPer { get; set; }
        public int TotalPer { get; set; }
        public string BillingDesc { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool Income { get; set; }
        public string IncomeBillingType { get; set; }
        public int IncomeCustNum { get; set; }
        public string ExpenditureType { get; set; }
        public string IncomeBcd { get; set; }
    }
}
