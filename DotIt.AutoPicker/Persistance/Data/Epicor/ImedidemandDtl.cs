using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImedidemandDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int EdiHedSeq { get; set; }
        public int EdiLineSeq { get; set; }
        public int EdiDtlSeq { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string Ponum { get; set; }
        public DateTime? ReqDate { get; set; }
        public decimal ReqQty { get; set; }
        public string ShipToNum { get; set; }
        public string ShipViaCode { get; set; }
        public bool OpenRelease { get; set; }
        public bool FirmRelease { get; set; }
        public bool Make { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string TaxExempt { get; set; }
        public int ShpConNum { get; set; }
        public DateTime? NeedByDate { get; set; }
        public string Reference { get; set; }
        public decimal ShippedQty { get; set; }
        public decimal CumeQty { get; set; }
        public DateTime? CumeDate { get; set; }
        public string JobNum { get; set; }
        public bool Post { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
