using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FiscalPer
    {
        public string Company { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool FaclosedPeriod { get; set; }
        public decimal AdditionalDeductions { get; set; }
        public decimal LossesCredit { get; set; }
        public decimal InvestmentCredit { get; set; }
        public decimal InventoriesCredit { get; set; }
        public decimal UpdateRate { get; set; }
        public bool DepHoliday { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int Jpyear { get; set; }
    }
}
