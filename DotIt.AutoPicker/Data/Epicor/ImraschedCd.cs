using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImraschedCd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Racode { get; set; }
        public string Radesc { get; set; }
        public int Duration { get; set; }
        public int DurationUom { get; set; }
        public bool ExceedDuration { get; set; }
        public int AmortFrequency { get; set; }
        public int CalcMethod { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Scope { get; set; }
        public bool Active { get; set; }
    }
}
