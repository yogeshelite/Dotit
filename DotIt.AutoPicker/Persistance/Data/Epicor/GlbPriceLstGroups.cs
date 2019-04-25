using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPriceLstGroups
    {
        public decimal BasePrice { get; set; }
        public string CommentText { get; set; }
        public string Company { get; set; }
        public decimal DiscountPercent1 { get; set; }
        public decimal DiscountPercent2 { get; set; }
        public decimal DiscountPercent3 { get; set; }
        public decimal DiscountPercent4 { get; set; }
        public decimal DiscountPercent5 { get; set; }
        public string ListCode { get; set; }
        public string ProdCode { get; set; }
        public decimal QtyBreak1 { get; set; }
        public decimal QtyBreak2 { get; set; }
        public decimal QtyBreak3 { get; set; }
        public decimal QtyBreak4 { get; set; }
        public decimal QtyBreak5 { get; set; }
        public decimal UnitPrice1 { get; set; }
        public decimal UnitPrice2 { get; set; }
        public decimal UnitPrice3 { get; set; }
        public decimal UnitPrice4 { get; set; }
        public decimal UnitPrice5 { get; set; }
        public string Uomcode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbListCode { get; set; }
        public string GlbProdCode { get; set; }
        public string GlbUomcode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPriceLstGroups { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
