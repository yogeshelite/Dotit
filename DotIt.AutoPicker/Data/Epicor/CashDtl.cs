﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CashDtl
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public int HeadNum { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceRef { get; set; }
        public string TranType { get; set; }
        public bool Posted { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public bool Glposted { get; set; }
        public DateTime? TranDate { get; set; }
        public string CheckRef { get; set; }
        public decimal TranAmt { get; set; }
        public decimal DocTranAmt { get; set; }
        public int CustNum { get; set; }
        public decimal Discount { get; set; }
        public decimal DocDiscount { get; set; }
        public string Comment { get; set; }
        public string Reference { get; set; }
        public decimal ExchangeRate { get; set; }
        public string LegalNumber { get; set; }
        public string GlrefType { get; set; }
        public string GlrefCode { get; set; }
        public bool DebitNote { get; set; }
        public string Dncomments { get; set; }
        public decimal Dnamount { get; set; }
        public decimal DocDnAmount { get; set; }
        public string DncustNbr { get; set; }
        public decimal RoundDiff { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal Rpt1DnAmount { get; set; }
        public decimal Rpt2DnAmount { get; set; }
        public decimal Rpt3DnAmount { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public string RateGrpCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string TaxRegionCode { get; set; }
        public bool GetDfltTaxIds { get; set; }
        public decimal WithholdAmt { get; set; }
        public decimal DocWithholdAmt { get; set; }
        public decimal Rpt1WithholdAmt { get; set; }
        public decimal Rpt2WithholdAmt { get; set; }
        public decimal Rpt3WithholdAmt { get; set; }
        public decimal SelfAssessAmt { get; set; }
        public decimal DocSelfAssessAmt { get; set; }
        public decimal Rpt1SelfAssessAmt { get; set; }
        public decimal Rpt2SelfAssessAmt { get; set; }
        public decimal Rpt3SelfAssessAmt { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal DocTaxAmt { get; set; }
        public decimal Rpt1TaxAmt { get; set; }
        public decimal Rpt2TaxAmt { get; set; }
        public decimal Rpt3TaxAmt { get; set; }
        public bool RedStorno { get; set; }
        public string IncomeTaxCode { get; set; }
        public DateTime? TaxReceiptDate { get; set; }
        public string TaxReceiptNo { get; set; }
        public DateTime? WhtcertificateDate { get; set; }
        public string WhtcertificateNo { get; set; }
        public string PcashDeskId { get; set; }
        public string GainLossType { get; set; }
        public int PcashRefNum { get; set; }
        public bool ReverseGl { get; set; }
        public DateTime? RevalueDate { get; set; }
        public decimal RevalueBal { get; set; }
        public decimal DocRevalueBal { get; set; }
        public decimal Rpt1RevalueBal { get; set; }
        public decimal Rpt2RevalueBal { get; set; }
        public decimal Rpt3RevalueBal { get; set; }
        public string TranDocTypeId { get; set; }
        public bool MainSite { get; set; }
        public string SiteCode { get; set; }
        public string BranchId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string TaxRemarks { get; set; }
        public string NonDeductCode { get; set; }
        public decimal NonDeductAmt { get; set; }
        public decimal NonDeductDocAmt { get; set; }
        public decimal NonDeductRpt1Amt { get; set; }
        public decimal NonDeductRpt2Amt { get; set; }
        public decimal NonDeductRpt3Amt { get; set; }
        public string AssetTypeCode { get; set; }
        public bool Cash { get; set; }
        public bool CreditCard { get; set; }
        public bool Normal { get; set; }
        public bool Excluded { get; set; }
        public bool Deferred { get; set; }
        public string SepaddmsgId { get; set; }
        public string SepaddpmtId { get; set; }
        public DateTime? PmtDueDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int MxpaymentNum { get; set; }
        public int WriteOffHeadNumRef { get; set; }
        public bool EpicorFsa { get; set; }
        public bool TaxableAdjustment { get; set; }
    }
}