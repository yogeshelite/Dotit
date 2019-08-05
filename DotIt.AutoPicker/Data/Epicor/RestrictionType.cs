using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RestrictionType
    {
        public string Company { get; set; }
        public string RestrictionTypeId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool Compliance { get; set; }
        public bool CheckPurchase { get; set; }
        public bool CheckJob { get; set; }
        public bool CheckRfq { get; set; }
        public bool CheckSoquote { get; set; }
        public bool GlobalRestrictionType { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
