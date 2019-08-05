using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Crmcall
    {
        public string Company { get; set; }
        public string RelatedToFile { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public int CallSeqNum { get; set; }
        public string CallDesc { get; set; }
        public string CallText { get; set; }
        public string SalesRepCode { get; set; }
        public string CallTypeCode { get; set; }
        public string CallContactType { get; set; }
        public int CallCustNum { get; set; }
        public string CallShipToNum { get; set; }
        public int CallConNum { get; set; }
        public int CallVendorNum { get; set; }
        public string CallPurPoint { get; set; }
        public int CallVconNum { get; set; }
        public string OrigDcdUserId { get; set; }
        public string LastDcdUserId { get; set; }
        public DateTime? OrigDate { get; set; }
        public int OrigTime { get; set; }
        public DateTime? LastDate { get; set; }
        public int LastTime { get; set; }
        public int CallQuoteNum { get; set; }
        public int CallQuoteLine { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public string CallEmpId { get; set; }
        public string CallBuyerId { get; set; }
        public int CallOrderNum { get; set; }
        public int CallInvoiceNum { get; set; }
        public int CallRmanum { get; set; }
        public int CallFscallNum { get; set; }
        public int PerConId { get; set; }
        public int CallHdcaseNum { get; set; }
        public string CallTaskId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CallPerConId { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public string CallProjectId { get; set; }
    }
}
