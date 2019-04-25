using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsubShipD
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public decimal ShipQty { get; set; }
        public int Packages { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public string ShipComment { get; set; }
        public string Wum { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public string Dum { get; set; }
        public decimal DimConvFactor { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
