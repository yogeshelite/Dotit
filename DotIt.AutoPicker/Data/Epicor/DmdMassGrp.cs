using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DmdMassGrp
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string CreatedBy { get; set; }
        public string ActiveUserId { get; set; }
        public DateTime? ApplyDate { get; set; }
        public bool GrpLocked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
