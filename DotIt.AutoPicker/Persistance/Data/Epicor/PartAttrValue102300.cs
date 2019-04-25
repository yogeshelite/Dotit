using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartAttrValue102300
    {
        public string Company { get; set; }
        public string AttrClassId { get; set; }
        public string AttributeId { get; set; }
        public string TableName { get; set; }
        public Guid ForeignSysRowId { get; set; }
        public string DataCharacter { get; set; }
        public DateTime? DataDate { get; set; }
        public decimal DataDecimal { get; set; }
        public int DataInteger { get; set; }
        public bool DataLogical { get; set; }
        public string FieldDataType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
