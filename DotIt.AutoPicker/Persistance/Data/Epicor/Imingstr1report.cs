using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imingstr1report
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Gstid { get; set; }
        public string Description { get; set; }
        public string ReportPeriod { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal MinInvoiceAmt { get; set; }
        public DateTime? ReportDate { get; set; }
        public string TaxLiabilityList { get; set; }
        public string TaxTypeList { get; set; }
        public string CustomerList { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmitDate { get; set; }
        public bool IsSubmitted { get; set; }
        public string ResponseStatus { get; set; }
        public string ResponseAckNum { get; set; }
        public DateTime? ResponseAckDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string InvNumSource { get; set; }
        public string SiteList { get; set; }
    }
}
