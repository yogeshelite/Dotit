using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpartBom
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string EndPartNum { get; set; }
        public string EndRevision { get; set; }
        public int BomSequence { get; set; }
        public int BomLevel { get; set; }
        public string MtlPartNum { get; set; }
        public string MtlRevision { get; set; }
        public string PartDescription { get; set; }
        public decimal QtyPer { get; set; }
        public decimal QtyRequired { get; set; }
        public string Bomtype { get; set; }
        public bool Approved { get; set; }
        public decimal TlrlaborCost { get; set; }
        public decimal TlrburdenCost { get; set; }
        public decimal TlrmaterialCost { get; set; }
        public decimal TlrsubcontractCost { get; set; }
        public decimal TlrmtlBurCost { get; set; }
        public decimal TlrsetupLaborCost { get; set; }
        public decimal TlrsetupBurdenCost { get; set; }
        public decimal LlrlaborCost { get; set; }
        public decimal LlrburdenCost { get; set; }
        public decimal LlrmaterialCost { get; set; }
        public decimal LlrsubcontractCost { get; set; }
        public decimal LlrmtlBurCost { get; set; }
        public decimal LlrsetupLaborCost { get; set; }
        public decimal LlrsetupBurdenCost { get; set; }
        public decimal SalvageQtyPer { get; set; }
        public decimal SalvageUnitCredit { get; set; }
        public string IndMtlPartNum { get; set; }
        public string EndAltMethod { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
