using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcurrExRate
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
