using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbInspAttr
    {
        public string AttributeId { get; set; }
        public string AttrType { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string FieldName { get; set; }
        public bool InActive { get; set; }
        public bool InUse { get; set; }
        public string GlbCompany { get; set; }
        public string GlbAttributeId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalInspAttr { get; set; }
        public bool GlobalLock { get; set; }
        public string AttributeUse { get; set; }
        public string GlbAttributeUse { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
