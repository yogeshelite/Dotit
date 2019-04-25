using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IminspAttr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AttributeUse { get; set; }
        public string AttributeId { get; set; }
        public bool InActive { get; set; }
        public string Description { get; set; }
        public string AttrType { get; set; }
        public string FieldName { get; set; }
        public bool InUse { get; set; }
        public bool GlobalInspAttr { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
