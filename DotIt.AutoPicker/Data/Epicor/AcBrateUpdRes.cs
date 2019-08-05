using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcBrateUpdRes
    {
        public string Company { get; set; }
        public decimal BrateUpdResId { get; set; }
        public decimal BrateUpdGrpId { get; set; }
        public decimal BrateUpdGrpBschId { get; set; }
        public decimal RabschHeadId { get; set; }
        public decimal RabschDtlId { get; set; }
        public decimal RabschDtlRatesId { get; set; }
        public decimal BschHeadId { get; set; }
        public decimal Raid { get; set; }
        public string BrateGroup { get; set; }
        public string Type { get; set; }
        public string ResidentCd { get; set; }
        public string ResidentName { get; set; }
        public int CustNum { get; set; }
        public string SegDisplayCd { get; set; }
        public bool PrevOver { get; set; }
        public DateTime? EffDt { get; set; }
        public string Bcd { get; set; }
        public decimal Rate { get; set; }
        public string Per { get; set; }
        public bool Overridden { get; set; }
        public bool Schedule { get; set; }
        public string StatusVal { get; set; }
        public bool Posted { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public bool InactiveRate { get; set; }
        public bool NewRate { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
