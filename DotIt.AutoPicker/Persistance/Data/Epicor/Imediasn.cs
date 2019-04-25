using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imediasn
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool Test { get; set; }
        public int PackNum { get; set; }
        public int OrderNum { get; set; }
        public int CustNum { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool Exported { get; set; }
        public DateTime? DateExported { get; set; }
        public bool Resend { get; set; }
        public DateTime? DateLastResend { get; set; }
        public string TradingPartId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
