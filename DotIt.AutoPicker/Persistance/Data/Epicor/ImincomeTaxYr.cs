using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImincomeTaxYr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public decimal Rate { get; set; }
        public bool Closed { get; set; }
        public bool Updated { get; set; }
        public string CreatedBy { get; set; }
        public string ClosedBy { get; set; }
        public string UpdatedBy { get; set; }
        public decimal AdditionalDeductions { get; set; }
        public decimal LossesCredit { get; set; }
        public decimal InvestmentCredit { get; set; }
        public decimal InventoriesCredit { get; set; }
        public decimal UpdateRate { get; set; }
        public decimal LossesToCarry { get; set; }
        public decimal IncomeAmt { get; set; }
        public decimal DeductionsAmt { get; set; }
        public decimal CreditsAmt { get; set; }
        public decimal OtherCreditPayAmt { get; set; }
        public decimal IncomeTaxIncurred { get; set; }
        public decimal AfterOtherCreditPayAmt { get; set; }
        public decimal AdvancePayAmount { get; set; }
        public decimal IncomeTaxToPaid { get; set; }
        public string Comments { get; set; }
        public string CurrencyCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
