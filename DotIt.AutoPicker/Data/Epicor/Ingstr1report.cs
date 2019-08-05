using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ingstr1report
    {
        public Ingstr1report()
        {
            Ingstr1reportDtl = new HashSet<Ingstr1reportDtl>();
        }

        public string Company { get; set; }
        public string ReportId { get; set; }
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

        public virtual ICollection<Ingstr1reportDtl> Ingstr1reportDtl { get; set; }
    }
}
