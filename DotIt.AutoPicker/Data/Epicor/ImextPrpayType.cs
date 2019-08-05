using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImextPrpayType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PayTypeId { get; set; }
        public string ExtPayTypeId { get; set; }
        public string Description { get; set; }
        public bool Otcalc { get; set; }
        public bool PayReg { get; set; }
        public bool PayOther { get; set; }
        public string OtherCode { get; set; }
        public bool SystemFlag { get; set; }
        public string IndirectCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
