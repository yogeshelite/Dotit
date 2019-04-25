using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbCurrExRate
    {
        public string Company { get; set; }
        public string SourceCurrCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal CurrentRate { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string EntryPerson { get; set; }
        public string Reference { get; set; }
        public string TargetCurrCode { get; set; }
        public string RateGrpCode { get; set; }
        public string GlbRateGrpCode { get; set; }
        public string GlbSourceCurrCode { get; set; }
        public string GlbTargetCurrCode { get; set; }
        public string GlbCompany { get; set; }
        public DateTime? GlbEffectiveDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
