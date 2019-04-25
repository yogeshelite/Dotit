using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImkanBanRcptSelectedSn
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReceiptId { get; set; }
        public string SerialNumber { get; set; }
        public string PartNum { get; set; }
        public string ScrapReasonCode { get; set; }
        public string SnbaseNumber { get; set; }
        public string RawSerialNum { get; set; }
        public bool Deselected { get; set; }
        public bool Scrapped { get; set; }
        public int KblbrAction { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
