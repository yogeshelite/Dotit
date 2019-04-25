using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbFaspread
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string CalendarId { get; set; }
        public string Company { get; set; }
        public bool DepRecalcNeeded { get; set; }
        public string Description { get; set; }
        public string SpreadCode { get; set; }
        public string SpreadType { get; set; }
        public string GlbCompany { get; set; }
        public string GlbSpreadCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFaspread { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
