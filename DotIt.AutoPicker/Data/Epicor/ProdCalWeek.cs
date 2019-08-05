using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProdCalWeek
    {
        public string Company { get; set; }
        public string CalendarId { get; set; }
        public DateTime? WorkDate { get; set; }
        public int WeekNum { get; set; }
        public int WeekYear { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
