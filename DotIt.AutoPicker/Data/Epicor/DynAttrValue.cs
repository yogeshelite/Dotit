using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DynAttrValue
    {
        public string Company { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public string AttrClassId { get; set; }
        public string AttributeId { get; set; }
        public string DataCharacter { get; set; }
        public DateTime? DataDate { get; set; }
        public decimal DataDecimal { get; set; }
        public int DataInteger { get; set; }
        public bool DataLogical { get; set; }
        public string FieldDataType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual DynAttrClassDtl DynAttrClassDtl { get; set; }
    }
}
