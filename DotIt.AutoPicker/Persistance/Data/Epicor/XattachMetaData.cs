using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class XattachMetaData
    {
        public string Company { get; set; }
        public string TableName { get; set; }
        public string DocTypeId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyDesc { get; set; }
        public string Mapping { get; set; }
        public bool IsMandatory { get; set; }
        public bool AllowOverride { get; set; }
        public string SpcolumnId { get; set; }
        public string PropertyValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
