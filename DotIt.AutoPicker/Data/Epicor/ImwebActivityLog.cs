using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImwebActivityLog
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int TranId { get; set; }
        public string TranType { get; set; }
        public string Direction { get; set; }
        public string BuyerId { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public string LogText { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsArchived { get; set; }
        public DateTime? TranDate { get; set; }
        public int NotifyId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
