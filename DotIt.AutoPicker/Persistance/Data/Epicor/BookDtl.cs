using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BookDtl
    {
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
