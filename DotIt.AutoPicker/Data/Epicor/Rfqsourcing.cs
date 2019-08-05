using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Rfqsourcing
    {
        public string Company { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public int SourcingSeq { get; set; }
        public string SourcingId { get; set; }
        public string SourcingStatus { get; set; }
        public string AuctionTitle { get; set; }
        public string BidAnonimity { get; set; }
        public string Category { get; set; }
        public decimal Duration { get; set; }
        public string EventType { get; set; }
        public string ItemDescription { get; set; }
        public decimal MinOfferDec { get; set; }
        public DateTime? PreviewDate { get; set; }
        public int PreviewTime { get; set; }
        public DateTime? StartingDate { get; set; }
        public int StartingTime { get; set; }
        public decimal ExpectedTotalPrice { get; set; }
        public decimal ActualTotalPrice { get; set; }
        public string AnonimityLevel { get; set; }
        public bool NegativeBids { get; set; }
        public string Uomcode { get; set; }
        public int UnitQty { get; set; }
        public string DecisionMakingRule { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal PriceIncrement { get; set; }
        public int TimeInterval { get; set; }
        public string Unspsc { get; set; }
        public string FormsOfPayment { get; set; }
        public string FreeOnBoard { get; set; }
        public string Terms { get; set; }
        public string ShippingOptions { get; set; }
        public string Location { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
