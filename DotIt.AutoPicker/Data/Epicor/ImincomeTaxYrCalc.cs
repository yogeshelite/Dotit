using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImincomeTaxYrCalc
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
        public int Seq { get; set; }
        public int Level { get; set; }
        public string Concept { get; set; }
        public string IncomeTaxCode { get; set; }
        public string IncomeTaxType { get; set; }
        public string Operator { get; set; }
        public decimal Amount { get; set; }
        public bool ReadOnly { get; set; }
        public int FactorOfSeq { get; set; }
        public string Id { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
