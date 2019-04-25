using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcRabondRefAus
    {
        public string Company { get; set; }
        public decimal RabondRefAusid { get; set; }
        public decimal Raid { get; set; }
        public decimal RabondAusid { get; set; }
        public string BschHeadCd { get; set; }
        public string BaseBcd { get; set; }
        public string Mpirbcd { get; set; }
        public int BaseInvoiceNum { get; set; }
        public int MpirinvoiceNum { get; set; }
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
