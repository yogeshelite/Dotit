using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EmpExpenseTax
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public int EmpExpenseNum { get; set; }
        public string TaxCode { get; set; }
        public string RateCode { get; set; }
        public int EcacquisitionSeq { get; set; }
        public decimal ExpReportableAmt { get; set; }
        public decimal ClaimReportableAmt { get; set; }
        public decimal ExpTaxableAmt { get; set; }
        public decimal ClaimTaxableAmt { get; set; }
        public decimal Percent { get; set; }
        public decimal ExpTaxAmt { get; set; }
        public decimal ClaimTaxAmt { get; set; }
        public bool Manual { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateTime { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool ReverseCharge { get; set; }
        public int CollectionType { get; set; }
        public int Timing { get; set; }
        public int ExemptType { get; set; }
        public decimal ExemptPercent { get; set; }
        public string ResolutionNum { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public DateTime? TaxRateDate { get; set; }
        public decimal ExpDefTaxableAmt { get; set; }
        public decimal ClaimDefTaxableAmt { get; set; }
        public decimal ExpDefTaxAmt { get; set; }
        public decimal ClaimDefTaxAmt { get; set; }
        public bool ManAdd { get; set; }
        public decimal ExpDedTaxAmt { get; set; }
        public decimal ClaimDedTaxAmt { get; set; }
        public decimal ExpFixedAmount { get; set; }
        public decimal ClaimFixedAmount { get; set; }
        public string TextCode { get; set; }
        public decimal ExpTaxAmtVar { get; set; }
        public decimal ClaimTaxAmtVar { get; set; }
        public decimal SysCalcClaimTaxableAmt { get; set; }
        public decimal SysCalcExpTaxableAmt { get; set; }
        public decimal SysCalcExpReportableAmt { get; set; }
        public decimal SysCalcClaimReportableAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
