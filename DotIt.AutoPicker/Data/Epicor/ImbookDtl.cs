using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbookDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public DateTime? BookDate { get; set; }
        public int BookTime { get; set; }
        public string RecType { get; set; }
        public int TranNum { get; set; }
        public string BookType { get; set; }
        public decimal OurBookQty { get; set; }
        public string ProdCode { get; set; }
        public decimal BookValue { get; set; }
        public string DcduserId { get; set; }
        public decimal SellingBookQty { get; set; }
        public string Ium { get; set; }
        public string SalesUm { get; set; }
        public decimal SellingFactor { get; set; }
        public string SellingFactorDirection { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
