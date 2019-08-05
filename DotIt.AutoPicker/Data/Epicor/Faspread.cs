using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Faspread
    {
        public string Company { get; set; }
        public string SpreadCode { get; set; }
        public string Description { get; set; }
        public string SpreadType { get; set; }
        public string CalendarId { get; set; }
        public bool GlobalFaspread { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
