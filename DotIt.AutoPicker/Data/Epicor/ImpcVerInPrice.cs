using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcVerInPrice
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int ConfigVersion { get; set; }
        public string UsedIn { get; set; }
        public string InputName { get; set; }
        public string InValue { get; set; }
        public decimal ValuePrice { get; set; }
        public string Multiplier { get; set; }
        public string ValueExpr { get; set; }
        public bool AllValues { get; set; }
        public string SourceDbrecid { get; set; }
        public string Comments { get; set; }
        public string ExtCompanyId { get; set; }
        public string CurrencyCode { get; set; }
        public int PriceHedSeq { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
