using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BroperationCustom
    {
        public string Company { get; set; }
        public int ActtypeUid { get; set; }
        public int ActrevisionUid { get; set; }
        public string BookId { get; set; }
        public int RuleUid { get; set; }
        public int OperationUid { get; set; }
        public int ParentOperationUid { get; set; }
        public int ChildSequenceNumber { get; set; }
        public string ControlFlowOperator { get; set; }
        public string Container { get; set; }
        public string Formula { get; set; }
        public int FunctionUid { get; set; }
        public string Prgtext { get; set; }
        public string Prgcontainer { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual BookingRule BookingRule { get; set; }
    }
}
