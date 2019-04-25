using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DynAttrClass
    {
        public DynAttrClass()
        {
            DynAttrClassDtl = new HashSet<DynAttrClassDtl>();
        }

        public string Company { get; set; }
        public string AttrClassId { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public bool WebAttrClass { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<DynAttrClassDtl> DynAttrClassDtl { get; set; }
    }
}
