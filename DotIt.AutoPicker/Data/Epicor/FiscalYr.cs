using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FiscalYr
    {
        public string Company { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int NumPeriods { get; set; }
        public int NumClosingPeriods { get; set; }
        public int NextFiscalYear { get; set; }
        public string NextFiscalYearSuffix { get; set; }
        public int PrevFiscalYear { get; set; }
        public string PrevFiscalYearSuffix { get; set; }
        public string Description { get; set; }
        public decimal IncomeTaxRate { get; set; }
        public decimal AdditionalDeductions { get; set; }
        public decimal LossesCredit { get; set; }
        public decimal InvestmentCredit { get; set; }
        public decimal InventoriesCredit { get; set; }
        public decimal UpdateRate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
