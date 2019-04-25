using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imrfqsugg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int SugNum { get; set; }
        public string LineDesc { get; set; }
        public string Ium { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string CommentText { get; set; }
        public string Class { get; set; }
        public string JobNum { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int AssemblySeq { get; set; }
        public int JobSeq { get; set; }
        public string ItemType { get; set; }
        public int VendorNum { get; set; }
        public int RfqvendQuotes { get; set; }
        public bool ProcessRfq { get; set; }
        public string GlbCompany { get; set; }
        public string PurPoint { get; set; }
        public string OpCode { get; set; }
        public string QtyList { get; set; }
        public bool GlbSuggestion { get; set; }
        public decimal RequiredQty { get; set; }
        public bool RcvInspectionReq { get; set; }
        public string WarehouseCode { get; set; }
        public string GlbJobPartNum { get; set; }
        public string GlbJobRevisionNum { get; set; }
        public string GlbJobPartDescription { get; set; }
        public decimal GlbJobProdQty { get; set; }
        public DateTime? GlbJobStartDate { get; set; }
        public string GlbJobProjectId { get; set; }
        public DateTime? GlbQuoteDueDate { get; set; }
        public bool GlbQuoteQuoted { get; set; }
        public DateTime? GlbQuoteDateQuoted { get; set; }
        public DateTime? GlbQuoteExpirationDate { get; set; }
        public DateTime? GlbQuoteFollowUpDate { get; set; }
        public string GlbQuoteReference { get; set; }
        public string GlbQuoteName { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int ReqNum { get; set; }
        public int ReqLine { get; set; }
        public string BuyerId { get; set; }
    }
}
