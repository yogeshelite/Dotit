using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BrfuncOperation
    {
        public int OperationUid { get; set; }
        public int ParentOperationUid { get; set; }
        public string ControlFlowOperator { get; set; }
        public string Container { get; set; }
        public string Formula { get; set; }
        public int SequenceNumber { get; set; }
        public int ChildSequenceNumber { get; set; }
        public int FunctionUid { get; set; }
        public string Prgtext { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public int FuncOperUid { get; set; }
        public string Company { get; set; }
        public string Prgcontainer { get; set; }
        public bool IsDefault { get; set; }
        public bool LocModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
