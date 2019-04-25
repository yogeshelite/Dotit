using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfassetReg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AssetRegId { get; set; }
        public string Description { get; set; }
        public string BookId { get; set; }
        public string CalendarId { get; set; }
        public bool DefaultReg { get; set; }
        public int CurrentFiscalYear { get; set; }
        public int CurrentFiscalPeriod { get; set; }
        public string CurrentFiscalYearSuffix { get; set; }
        public bool RetroAdjust { get; set; }
        public string DepRevalueMethod { get; set; }
        public bool AllowUpwardRevalue { get; set; }
        public bool TransRevalSurplus { get; set; }
        public bool DynamicDepYear { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
