using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DemandBook
    {
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int TranNum { get; set; }
        public DateTime? BookDate { get; set; }
        public int BookTime { get; set; }
        public decimal PrevBookQty { get; set; }
        public decimal BookQty { get; set; }
        public DateTime? PrevNeedByDate { get; set; }
        public DateTime? NeedByDate { get; set; }
        public DateTime? PrevShipByDate { get; set; }
        public DateTime? ShipByDate { get; set; }
        public int PrevShipToCustNum { get; set; }
        public int ShipToCustNum { get; set; }
        public string PrevShipToNum { get; set; }
        public string ShipToNum { get; set; }
        public string PrevShipViaCode { get; set; }
        public string ShipViaCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
