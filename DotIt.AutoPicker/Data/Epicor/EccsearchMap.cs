using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EccsearchMap
    {
        public string MessageType { get; set; }
        public string Ecccolumn { get; set; }
        public string ErpschemaName { get; set; }
        public string ErptableName { get; set; }
        public string ErpcolumnName { get; set; }
        public bool UsedInQuery { get; set; }
        public string FreeFormQuery { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
