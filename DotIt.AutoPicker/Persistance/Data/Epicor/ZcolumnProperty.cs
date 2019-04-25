using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ZcolumnProperty
    {
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string FieldName { get; set; }
        public string PropertyId { get; set; }
        public bool SystemFlag { get; set; }
        public string PropertyValue { get; set; }
        public string OverrideValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZdataField ZdataField { get; set; }
    }
}
