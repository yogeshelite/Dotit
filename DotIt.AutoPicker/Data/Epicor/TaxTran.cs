using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxTran
    {
        public TaxTran()
        {
            WhtpaymentDtl = new HashSet<WhtpaymentDtl>();
        }

        public string Company { get; set; }
        public DateTime TranDate { get; set; }
        public int TranNum { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public int VendorNum { get; set; }
        public int CustNum { get; set; }
        public int ArinvoiceNum { get; set; }
        public bool InEc { get; set; }
        public string TaxRegionCode { get; set; }
        public string TaxCode { get; set; }
        public decimal Percent { get; set; }
        public string SourceModule { get; set; }
        public decimal TaxableAmt { get; set; }
        public decimal DocTaxableAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal DocTaxAmt { get; set; }
        public string CompTaxId { get; set; }
        public string VendorTaxId { get; set; }
        public string CustomerTaxId { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string ApinvoiceNum { get; set; }
        public string ReportId { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public int EcacquisitionSeq { get; set; }
        public int InvoiceLine { get; set; }
        public int SeqNum { get; set; }
        public bool ReverseCharge { get; set; }
        public decimal ReportableAmt { get; set; }
        public decimal DocReportableAmt { get; set; }
        public bool InvoiceMemo { get; set; }
        public decimal Rpt1ReportableAmt { get; set; }
        public decimal Rpt2ReportableAmt { get; set; }
        public decimal Rpt3ReportableAmt { get; set; }
        public decimal Rpt1TaxableAmt { get; set; }
        public decimal Rpt2TaxableAmt { get; set; }
        public decimal Rpt3TaxableAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public string RateGrpCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string TaxCatId { get; set; }
        public string RateCode { get; set; }
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? TaxPoint { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public string LegalNumber { get; set; }
        public DateTime? TaxPrintDate { get; set; }
        public bool TaxPosted { get; set; }
        public DateTime? TaxPostDate { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public string ResolutionNum { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public bool EuthirdParty { get; set; }
        public string TaxExempt { get; set; }
        public int HeadNum { get; set; }
        public decimal RecoverableAmt { get; set; }
        public decimal DocRecoverableAmt { get; set; }
        public decimal Rpt1RecoverableAmt { get; set; }
        public decimal Rpt2RecoverableAmt { get; set; }
        public decimal Rpt3RecoverableAmt { get; set; }
        public DateTime? ArinvoiceDate { get; set; }
        public string TextCode { get; set; }
        public decimal TaxAmtVar { get; set; }
        public decimal DocTaxAmtVar { get; set; }
        public decimal Rpt1TaxAmtVar { get; set; }
        public decimal Rpt2TaxAmtVar { get; set; }
        public decimal Rpt3TaxAmtVar { get; set; }
        public string RevRptCatCode { get; set; }
        public int AptranNo { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ReturnFlag { get; set; }
        public string BookId { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public int JournalLine { get; set; }
        public string CooneTimeId { get; set; }
        public string TempVendorTaxId { get; set; }
        public string TranDocTypeId { get; set; }
        public bool Reverse { get; set; }
        public string TranType { get; set; }
        public int MovementNum { get; set; }
        public string NlicpreportId { get; set; }
        public int MscNum { get; set; }
        public string MiscCode { get; set; }

        public virtual ICollection<WhtpaymentDtl> WhtpaymentDtl { get; set; }
    }
}
