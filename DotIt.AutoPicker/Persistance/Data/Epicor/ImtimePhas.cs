using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtimePhas
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string PartNum { get; set; }
        public bool SortByDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool RequirementFlag { get; set; }
        public decimal ReceiptQty { get; set; }
        public decimal RequiredQty { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public int LeadTime { get; set; }
        public decimal BalanceQty { get; set; }
        public string ExceptionReason { get; set; }
        public DateTime? SugOrderDate { get; set; }
        public string SourceName { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public bool BuyForJob { get; set; }
        public bool PrintMe { get; set; }
        public string SourceFile { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public DateTime? PromiseDate { get; set; }
        public string ContractId { get; set; }
        public bool LinkToContract { get; set; }
    }
}
