using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IntParamDef
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ParamName { get; set; }
        public string ParamType { get; set; }
        public string ImtableName { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
