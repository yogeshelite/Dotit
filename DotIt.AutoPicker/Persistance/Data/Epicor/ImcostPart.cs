using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcostPart
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string SearchWord { get; set; }
        public string PartDescription { get; set; }
        public string ClassId { get; set; }
        public string TypeCode { get; set; }
        public string ProdCode { get; set; }
        public decimal StdLaborCost { get; set; }
        public decimal StdBurdenCost { get; set; }
        public decimal StdMaterialCost { get; set; }
        public decimal StdSubContCost { get; set; }
        public decimal StdMtlBurCost { get; set; }
        public string RevisionNum { get; set; }
        public DateTime? EffectiveDate { get; set; }
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
        public DateTime? RollupDate { get; set; }
        public string AltMethod { get; set; }
        public bool Linked { get; set; }
        public decimal MfgLotSize { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PrimCostPart { get; set; }
        public string PrimCostRev { get; set; }
        public string PrimCostAltMethod { get; set; }
        public decimal CoPartsReqQty { get; set; }
        public decimal MtlCostPct { get; set; }
        public decimal LaborCostPct { get; set; }
        public decimal OrigStdMaterialCost { get; set; }
        public decimal OrigStdLaborCost { get; set; }
        public decimal OrigStdBurdenCost { get; set; }
        public decimal OrigStdSubContCost { get; set; }
        public decimal OrigStdMtlBurCost { get; set; }
        public bool IsTransferCostId { get; set; }
    }
}
