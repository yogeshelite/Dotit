using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbookVar
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int ActtypeUid { get; set; }
        public int ActrevisionUid { get; set; }
        public string BookId { get; set; }
        public int BookVarUid { get; set; }
        public string VarName { get; set; }
        public string VarType { get; set; }
        public string VType { get; set; }
        public int VUid { get; set; }
        public string Company { get; set; }
        public bool IsDefault { get; set; }
        public bool LocModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
