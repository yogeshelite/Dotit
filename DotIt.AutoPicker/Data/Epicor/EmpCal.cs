using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EmpCal
    {
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string CalendarId { get; set; }
        public DateTime? FromEffectiveDate { get; set; }
        public DateTime? ToEffectiveDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
