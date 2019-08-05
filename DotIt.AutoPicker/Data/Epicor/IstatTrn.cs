using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IstatTrn
    {
        public string Flow { get; set; }
        public string Period { get; set; }
        public string CommodityCode { get; set; }
        public decimal Amount { get; set; }
        public string Terms { get; set; }
        public string TransactionType { get; set; }
        public decimal Weight { get; set; }
        public string IscountryCode { get; set; }
        public string IsshipViaCode { get; set; }
        public string BorderCrossing { get; set; }
        public string FlowSpec { get; set; }
        public string Iscurrency { get; set; }
        public string Description { get; set; }
        public decimal SuppUnits { get; set; }
        public string Company { get; set; }
        public string SourceModule { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public bool Posted { get; set; }
        public int VendorNum { get; set; }
        public bool MemoFlag { get; set; }
        public string ShipViaCode { get; set; }
        public string Fob { get; set; }
        public string TaxId { get; set; }
        public decimal InvAmount { get; set; }
        public DateTime? TransDate { get; set; }
        public bool NotReported { get; set; }
        public string Isregion { get; set; }
        public string IsorigCountry { get; set; }
        public string IntCommCode { get; set; }
        public string StampId { get; set; }
        public int SeqNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CommentText { get; set; }
    }
}
