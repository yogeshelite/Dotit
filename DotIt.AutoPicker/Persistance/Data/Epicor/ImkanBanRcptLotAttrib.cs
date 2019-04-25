using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImkanBanRcptLotAttrib
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
        public string PartNum { get; set; }
        public string LotNum { get; set; }
        public string PartLotDescription { get; set; }
        public string Batch { get; set; }
        public string MfgBatch { get; set; }
        public string MfgLot { get; set; }
        public string FirmWare { get; set; }
        public DateTime? BestBeforeDt { get; set; }
        public DateTime? MfgDt { get; set; }
        public DateTime? CureDt { get; set; }
        public DateTime? ExpireDt { get; set; }
        public bool ShipDocAvail { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
