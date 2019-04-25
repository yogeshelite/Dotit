using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imfagroup
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string Description { get; set; }
        public string JournalCode { get; set; }
        public bool Finalspread { get; set; }
        public bool AdditionSpread { get; set; }
        public string AssetMethod { get; set; }
        public bool GlobalFagroup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CategoryCode { get; set; }
    }
}
