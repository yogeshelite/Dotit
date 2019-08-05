using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EdidemandHed
    {
        public string Company { get; set; }
        public string DemandType { get; set; }
        public bool Test { get; set; }
        public int EdiHedSeq { get; set; }
        public int OrderNum { get; set; }
        public int CustNum { get; set; }
        public string TradingPartId { get; set; }
        public string Ponum { get; set; }
        public bool OrderHeld { get; set; }
        public string ShipToNum { get; set; }
        public string EdishipToNum { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? AckDate { get; set; }
        public DateTime? AckDateExp { get; set; }
        public DateTime? ChgOrderDate { get; set; }
        public int ChgOrdSeq { get; set; }
        public string Fob { get; set; }
        public string ShipViaCode { get; set; }
        public string TermsCode { get; set; }
        public decimal DiscountPercent { get; set; }
        public int ProConNum { get; set; }
        public int ShpConNum { get; set; }
        public string SalesRepList { get; set; }
        public string OrderComment { get; set; }
        public string ShipComment { get; set; }
        public string InvoiceComment { get; set; }
        public string PickListComment { get; set; }
        public DateTime? NeedByDate { get; set; }
        public DateTime? ImportDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool Posted { get; set; }
        public bool Send { get; set; }
        public bool Post { get; set; }
        public string EdidocNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
