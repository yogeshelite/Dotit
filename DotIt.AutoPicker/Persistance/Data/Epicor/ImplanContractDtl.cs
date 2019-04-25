using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImplanContractDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ContractId { get; set; }
        public int LineNum { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public decimal ContractQty { get; set; }
        public string ContractUom { get; set; }
        public DateTime? DueDate { get; set; }
        public string Comments { get; set; }
        public decimal OurContractQty { get; set; }
        public decimal ConsumedQty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal CompletedQty { get; set; }
    }
}
