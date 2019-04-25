using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ClassExtendedCrossRef
    {
        public string Company { get; set; }
        public string SystemCode { get; set; }
        public string TableName { get; set; }
        public string LogicalFieldName { get; set; }
        public string UserId { get; set; }
        public string Program { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
