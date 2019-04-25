using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprtaxDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxTblId { get; set; }
        public int TaxYear { get; set; }
        public string FileStatus { get; set; }
        public string FileStatusDesc { get; set; }
        public string TaxBasis { get; set; }
        public decimal TaxableWageLimit { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal StdDeductionMin { get; set; }
        public decimal StdDeductionMax { get; set; }
        public decimal StdDeductionPct { get; set; }
        public decimal StdDeduction0 { get; set; }
        public decimal StdDeduction1 { get; set; }
        public decimal StdDeduction2 { get; set; }
        public decimal PersonalExAmt { get; set; }
        public decimal DependentExAmt { get; set; }
        public decimal PersonalCrAmt { get; set; }
        public decimal DependentCrAmt { get; set; }
        public decimal FitexPct { get; set; }
        public decimal FitexMax { get; set; }
        public decimal FicaexPct { get; set; }
        public decimal FicaexMax { get; set; }
        public decimal WeeklyLimit { get; set; }
        public decimal SupplementalPercent { get; set; }
        public decimal AddTaxPercent { get; set; }
        public decimal AddTaxAmount { get; set; }
        public decimal AddDeductionPercent { get; set; }
        public decimal AddDeductionAmt1 { get; set; }
        public decimal AddDeductionAmt2 { get; set; }
        public decimal TaxableThreshold { get; set; }
        public decimal AboveThresholdPercent { get; set; }
        public decimal AboveThresholdAdditionalAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
