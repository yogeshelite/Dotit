using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtPrpayType
    {
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
