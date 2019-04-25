using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Rfqitem
    {
        public string Company { get; set; }
        public bool OpenItem { get; set; }
        public int Rfqnum { get; set; }
        public int Rfqline { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string CommentText { get; set; }
        public string ClassId { get; set; }
        public string JobNum { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public string ItemType { get; set; }
        public string OpCode { get; set; }
        public int AssemblySeq { get; set; }
        public int JobSeq { get; set; }
        public int RfqvendQuotes { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRfqnum { get; set; }
        public int GlbRfqline { get; set; }
        public decimal RequiredQty { get; set; }
        public bool RcvInspectionReq { get; set; }
        public string WarehouseCode { get; set; }
        public int SrcVendQuotes { get; set; }
        public bool ValidSrc { get; set; }
        public string Pum { get; set; }
        public decimal PurchasingFactor { get; set; }
        public string PurchasingFactorDirection { get; set; }
        public string ComplianceMsg { get; set; }
        public string UomclassId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int ReqNum { get; set; }
        public int ReqLine { get; set; }
    }
}
