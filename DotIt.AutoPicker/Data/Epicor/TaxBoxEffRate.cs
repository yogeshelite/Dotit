using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxBoxEffRate
    {
        public string Company { get; set; }
        public string TaxCode { get; set; }
        public string BoxCode { get; set; }
        public string SourceModule { get; set; }
        public string AmountType { get; set; }
        public int EcacquisitionSeq { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public string BoxSign { get; set; }
        public string RateCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
