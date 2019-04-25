using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class KanBanRcptLotAttrib
    {
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
