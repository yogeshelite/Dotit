using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Fagroup
    {
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
