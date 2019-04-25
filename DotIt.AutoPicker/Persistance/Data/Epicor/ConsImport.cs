using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ConsImport
    {
        public string Company { get; set; }
        public int GenId { get; set; }
        public string Description { get; set; }
        public string BookId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string FiscalCalendarId { get; set; }
        public DateTime? ImportDate { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string JournalCode { get; set; }
        public string JrnlHeadDesc { get; set; }
        public string ImportStatus { get; set; }
        public string ImportFileName { get; set; }
        public string GenerationLog { get; set; }
        public string GroupId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
