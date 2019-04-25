using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GljrnHed
    {
        public string Company { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public int JournalNum { get; set; }
        public string Description { get; set; }
        public DateTime? Jedate { get; set; }
        public string GroupId { get; set; }
        public decimal TotDebit { get; set; }
        public decimal TotCredit { get; set; }
        public bool Override { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public string LegalNumber { get; set; }
        public string EnteredBy { get; set; }
        public bool Reverse { get; set; }
        public DateTime? ReverseDate { get; set; }
        public string JournalCode { get; set; }
        public bool MultiCompany { get; set; }
        public string CommentText { get; set; }
        public DateTime? GlbPostedDate { get; set; }
        public int GlbJournalNum { get; set; }
        public string GlbJournalCode { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbApinvoiceNum { get; set; }
        public string GlbVendorId { get; set; }
        public string GlbVendorName { get; set; }
        public string GlbAplegalNumber { get; set; }
        public string GlbApinvDesc { get; set; }
        public bool Linked { get; set; }
        public string GlbCompanyId { get; set; }
        public int GlbFiscalYear { get; set; }
        public int GlbFiscalPeriod { get; set; }
        public string GlbGroupId { get; set; }
        public string GlbJournalCodeDesc { get; set; }
        public string GlbEnteredBy { get; set; }
        public string BookId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string GlbFiscalYearSuffix { get; set; }
        public string GlbFiscalCalendarId { get; set; }
        public int CloseFiscalPeriod { get; set; }
        public bool RedStorno { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public decimal DebitStatAmt { get; set; }
        public int ProcessType { get; set; }
        public decimal CreditStatAmt { get; set; }
        public bool CorrAccounting { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TaxHandling { get; set; }
        public string TranDocTypeId { get; set; }
        public bool Statistical { get; set; }
        public bool TransferredToParent { get; set; }
        public DateTime? TransferredDate { get; set; }
        public string TransferredPerson { get; set; }
        public string MxfiscalFolio { get; set; }
        public string Mxrfc { get; set; }
        public bool JournalHeld { get; set; }
    }
}
