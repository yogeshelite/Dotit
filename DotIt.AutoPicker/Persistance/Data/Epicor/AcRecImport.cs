using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcRecImport
    {
        public string Company { get; set; }
        public decimal RecHeadId { get; set; }
        public decimal RecImportId { get; set; }
        public string Resident { get; set; }
        public string ReferenceCode { get; set; }
        public string Bcd { get; set; }
        public string BillGroupCd { get; set; }
        public string BadjRsnCd { get; set; }
        public bool Cadj { get; set; }
        public decimal PaidQty { get; set; }
        public decimal PaidRate { get; set; }
        public string ErrorLog { get; set; }
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
