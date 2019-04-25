using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imoprice
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BreakType { get; set; }
        public string PartNum { get; set; }
        public string ProdCode { get; set; }
        public int CustNum { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ListCode { get; set; }
        public decimal DiscountPercent2 { get; set; }
        public decimal DiscountPercent3 { get; set; }
        public decimal DiscountPercent4 { get; set; }
        public decimal DiscountPercent5 { get; set; }
        public decimal QtyBreak1 { get; set; }
        public decimal QtyBreak2 { get; set; }
        public decimal QtyBreak3 { get; set; }
        public decimal QtyBreak4 { get; set; }
        public decimal QtyBreak5 { get; set; }
        public decimal DiscountPercent1 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
