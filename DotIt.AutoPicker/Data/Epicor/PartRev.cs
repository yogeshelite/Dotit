using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartRev
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string RevShortDesc { get; set; }
        public string RevDescription { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
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
        public string DrawNum { get; set; }
        public string Eco { get; set; }
        public bool Method { get; set; }
        public int AutoRecOpr { get; set; }
        public int FinalOpr { get; set; }
        public string PdmobjId { get; set; }
        public bool Configured { get; set; }
        public bool WebConfigured { get; set; }
        public bool ShowInputPrice { get; set; }
        public string AltMethod { get; set; }
        public string AltMethodDesc { get; set; }
        public string Plant { get; set; }
        public string ParentAltMethod { get; set; }
        public bool UseStaging { get; set; }
        public bool UseAltRevForParts { get; set; }
        public string OwnershipStatus { get; set; }
        public bool ExtConfig { get; set; }
        public bool ValRefDes { get; set; }
        public bool PcGlobalPart { get; set; }
        public bool PcEntprsConf { get; set; }
        public bool GlobalRev { get; set; }
        public string RoughCutCode { get; set; }
        public string RmainspPlan { get; set; }
        public string RmaspecId { get; set; }
        public decimal RmasampleSize { get; set; }
        public decimal RmasampleSizePct { get; set; }
        public string BasePartNum { get; set; }
        public string BaseRevisionNum { get; set; }
        public string ConfigId { get; set; }
        public bool RegenConfig { get; set; }
        public int SivaluesGroupSeq { get; set; }
        public int SivaluesHeadNum { get; set; }
        public bool ExternalMes { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ProcessMode { get; set; }
        public bool DefaultConfigPart { get; set; }
        public decimal CoPartsReqQty { get; set; }
        public decimal MtlCostPct { get; set; }
        public decimal LaborCostPct { get; set; }
        public int CoPartsPerOp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
