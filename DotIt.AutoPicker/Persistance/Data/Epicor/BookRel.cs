using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BookRel
    {
        public string Company { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public DateTime? BookDate { get; set; }
        public int BookTime { get; set; }
        public string RecType { get; set; }
        public int TranNum { get; set; }
        public string BookType { get; set; }
        public string DcduserId { get; set; }
        public DateTime? ReqDate { get; set; }
        public decimal OurReqQty { get; set; }
        public string ShipToNum { get; set; }
        public string ShipViaCode { get; set; }
        public string WarehouseCode { get; set; }
        public DateTime? NeedByDate { get; set; }
        public string Plant { get; set; }
        public decimal SellingReqQty { get; set; }
        public decimal OurJobQty { get; set; }
        public decimal OurJobShippedQty { get; set; }
        public decimal OurStockQty { get; set; }
        public decimal OurStockShippedQty { get; set; }
        public decimal SellingJobQty { get; set; }
        public decimal SellingJobShippedQty { get; set; }
        public decimal SellingStockQty { get; set; }
        public decimal SellingStockShippedQty { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
