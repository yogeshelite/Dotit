using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LocationIdnum
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public int SeqNum { get; set; }
        public string JobNum { get; set; }
        public string SerialNo { get; set; }
        public string Idnum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string BinNum { get; set; }
        public string LotNum { get; set; }
        public string PartNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string Status { get; set; }
        public bool Selected { get; set; }
        public string WarehouseCode { get; set; }
    }
}
