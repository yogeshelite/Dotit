using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RaschedCd
    {
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
