using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcnfassetChange
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public string ChangedFieldName { get; set; }
        public int ChangeNum { get; set; }
        public string ChangedFieldValue { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangedBy { get; set; }
        public string Reason { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
