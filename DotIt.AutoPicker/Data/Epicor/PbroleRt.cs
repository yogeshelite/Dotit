using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbroleRt
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string RoleCd { get; set; }
        public DateTime? RateEffDate { get; set; }
        public string TimeTypCd { get; set; }
        public decimal ChargeRate { get; set; }
        public decimal Ceiling { get; set; }
        public decimal DocCeiling { get; set; }
        public decimal Rpt1Ceiling { get; set; }
        public decimal Rpt2Ceiling { get; set; }
        public decimal Rpt3Ceiling { get; set; }
        public bool ExcludeInvoiced { get; set; }
        public DateTime? RateEndDate { get; set; }
        public int Seq { get; set; }
        public decimal PrcMarkup { get; set; }
        public bool OridePrcMarkup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
