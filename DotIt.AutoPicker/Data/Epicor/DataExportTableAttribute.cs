using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DataExportTableAttribute
    {
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string TableName { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
