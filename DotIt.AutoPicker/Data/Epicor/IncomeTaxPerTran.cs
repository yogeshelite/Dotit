using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IncomeTaxPerTran
    {
        public string Company { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public int Seq { get; set; }
        public string IncomeTaxCode { get; set; }
        public decimal Amount { get; set; }
        public int DocumentType { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Key4 { get; set; }
        public string Key5 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
