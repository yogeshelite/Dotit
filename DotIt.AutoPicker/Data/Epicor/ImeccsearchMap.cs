using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImeccsearchMap
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
