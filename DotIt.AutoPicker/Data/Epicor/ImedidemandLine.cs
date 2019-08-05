using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImedidemandLine
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
        public int EdilineSeq { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string ChgLineType { get; set; }
        public string PartNum { get; set; }
        public string LineDescription { get; set; }
        public string Reference { get; set; }
        public string VendUm { get; set; }
        public string RevisionNum { get; set; }
        public string Ponum { get; set; }
        public string PolineNum { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineQty { get; set; }
        public DateTime? RequestDate { get; set; }
        public string XpartNum { get; set; }
        public string XrevisionNum { get; set; }
        public string XpartDesc { get; set; }
        public string PricePerCode { get; set; }
        public string OrderComment { get; set; }
        public string ShipComment { get; set; }
        public string InvoiceComment { get; set; }
        public string PickListComment { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public DateTime? NeedByDate { get; set; }
        public int CustNum { get; set; }
        public string BasePartNum { get; set; }
        public string SalesUm { get; set; }
        public decimal SalesFactor { get; set; }
        public decimal SalesQuantity { get; set; }
        public decimal Cumquantity { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public string SalesFactorDirection { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
