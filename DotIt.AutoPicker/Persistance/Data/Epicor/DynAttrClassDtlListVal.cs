using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DynAttrClassDtlListVal
    {
        public string Company { get; set; }
        public string AttrClassId { get; set; }
        public string AttributeId { get; set; }
        public string Code { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual DynAttrClassDtl DynAttrClassDtl { get; set; }
    }
}
