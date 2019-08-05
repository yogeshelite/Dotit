using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EmpExpense
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public int EmpExpenseNum { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public string ClaimRef { get; set; }
        public string QuickEntryCode { get; set; }
        public bool Indirect { get; set; }
        public string ProjectId { get; set; }
        public string PhaseId { get; set; }
        public int Pmuid { get; set; }
        public decimal Units { get; set; }
        public decimal UnitRate { get; set; }
        public DateTime? UbfromEffectiveDate { get; set; }
        public string ExpCurrencyCode { get; set; }
        public string TaxRegionCode { get; set; }
        public decimal DocExpenseTaxAmt { get; set; }
        public decimal DocExpenseAmt { get; set; }
        public bool TaxIncluded { get; set; }
        public decimal DocTotalExpenseAmt { get; set; }
        public string ExpenseStatus { get; set; }
        public string ChargeCurrencyCode { get; set; }
        public decimal ChargeExchangeRate { get; set; }
        public string ChargeRateGrpCode { get; set; }
        public decimal DocChargeAmt { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string TaskSetId { get; set; }
        public bool IsReversal { get; set; }
        public int ReversedExpenseNum { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateTime { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public string ActiveTaskId { get; set; }
        public string LastTaskId { get; set; }
        public string ClaimCurrencyCode { get; set; }
        public decimal ClaimExchangeRate { get; set; }
        public bool ClaimLockRate { get; set; }
        public string ClaimRateGrpCode { get; set; }
        public decimal DocClaimTaxAmt { get; set; }
        public decimal DocClaimAmt { get; set; }
        public decimal DocTotalClaimAmt { get; set; }
        public string MiscCode { get; set; }
        public string SubmittedBy { get; set; }
        public string CurrentWfstageId { get; set; }
        public string WfgroupId { get; set; }
        public bool Wfcomplete { get; set; }
        public bool ApprovalRequired { get; set; }
        public string TaxExempt { get; set; }
        public bool GetDfltTaxIds { get; set; }
        public bool TaxConnectCalc { get; set; }
        public decimal DocExpWithholdAmt { get; set; }
        public decimal DocClaimWithholdAmt { get; set; }
        public bool Reimbursable { get; set; }
        public decimal DocChargeTaxAmt { get; set; }
        public decimal DocTotalChargeAmt { get; set; }
        public decimal ClaimToBaseExchangeRate { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public bool Invoiced { get; set; }
        public string ExpCommentText { get; set; }
        public string ExpCommentInstr { get; set; }
        public bool ProjProcessed { get; set; }
        public DateTime? AsOfDate { get; set; }
        public int AsOfSeq { get; set; }
        public string ExpenseCategory { get; set; }
        public string VoucherReceiptNo { get; set; }
        public DateTime? VoucherReceiptDate { get; set; }
        public decimal DocAdvanceBalance { get; set; }
        public decimal DocMatchedClaimAmt { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public Guid PartTranSysRowId { get; set; }
        public bool ExpenseAutoSubmit { get; set; }
        public bool EpicorFsa { get; set; }
    }
}
