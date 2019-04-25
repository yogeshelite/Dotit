using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbCurrRateDisp
    {
        public string Company { get; set; }
        public string RateGrpCode { get; set; }
        public int Seq { get; set; }
        public string CurrencyCode { get; set; }
        public string GlbRateGrpCode { get; set; }
        public string GlbCompany { get; set; }
        public int GlbSeq { get; set; }
        public int ScaleFactor { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
