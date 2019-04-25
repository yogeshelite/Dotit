using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxBoxEffRate
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
