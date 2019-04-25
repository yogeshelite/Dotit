using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BpHoldAttachment
    {
        public string Company { get; set; }
        public string HoldTypeId { get; set; }
        public int HoldAttachId { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Comment { get; set; }
        public Guid HoldSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
