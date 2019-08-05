using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CurrRateDisp
    {
        public string Company { get; set; }
        public string RateGrpCode { get; set; }
        public int Seq { get; set; }
        public string CurrencyCode { get; set; }
        public int ScaleFactor { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
