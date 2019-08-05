using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbCurrRateGrp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GlbRateGrpCode { get; set; }
        public string GlbCompany { get; set; }
        public bool Skipped { get; set; }
        public string RateGrpCode { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string BaseRateGrpCode { get; set; }
        public string CrossCurrCode { get; set; }
        public bool CrossRound { get; set; }
        public int CrossRoundDec { get; set; }
        public string AltCrossCurrCode { get; set; }
        public bool AltCrossRound { get; set; }
        public int AltCrossRoundDec { get; set; }
        public bool GlobalGrp { get; set; }
        public bool GlobalLock { get; set; }
        public int DisplayMode { get; set; }
        public int RateNumDec { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
