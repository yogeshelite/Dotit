using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImjobClosingLog
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AuditSource { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string SeqType { get; set; }
        public int JobSeq { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public string MtlPartNum { get; set; }
        public decimal EstQuantity { get; set; }
        public decimal ActQuantity { get; set; }
        public decimal EstCost { get; set; }
        public decimal ActCost { get; set; }
        public int AllowedQtyPercent { get; set; }
        public int AllowedCostPercent { get; set; }
        public int ActualQtyPercent { get; set; }
        public int ActualCostPercent { get; set; }
        public DateTime? LastProcessDate { get; set; }
        public int LastProcessTime { get; set; }
        public string LastProcessUser { get; set; }
        public string ErrorDescription { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
