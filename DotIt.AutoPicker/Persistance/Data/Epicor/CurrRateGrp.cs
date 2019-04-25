using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CurrRateGrp
    {
        public string Company { get; set; }
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
        public int RateNumDec { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
