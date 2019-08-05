using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartMtl
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int MtlSeq { get; set; }
        public string MtlPartNum { get; set; }
        public decimal QtyPer { get; set; }
        public bool FixedQty { get; set; }
        public int RelatedOperation { get; set; }
        public string SalvagePartNum { get; set; }
        public string SalvageDescription { get; set; }
        public decimal SalvageQtyPer { get; set; }
        public string SalvageUm { get; set; }
        public decimal SalvageUnitCredit { get; set; }
        public string MfgComment { get; set; }
        public bool OverRideMfgComments { get; set; }
        public string PurComment { get; set; }
        public bool OverRidePurComments { get; set; }
        public decimal EstScrap { get; set; }
        public string EstScrapType { get; set; }
        public bool PullAsAsm { get; set; }
        public string FindNum { get; set; }
        public bool ViewAsAsm { get; set; }
        public string ApsschedulerName { get; set; }
        public DateTime? Apssldate { get; set; }
        public decimal Apssltime { get; set; }
        public string ApsinsertDirection { get; set; }
        public string ApsinsertCriteria { get; set; }
        public decimal Apsattrib1 { get; set; }
        public decimal Apsattrib2 { get; set; }
        public decimal Apsattrib3 { get; set; }
        public decimal Apsattrib4 { get; set; }
        public string ApsaddResType { get; set; }
        public decimal SalvageMtlBurRate { get; set; }
        public decimal SalvageEstMtlBurUnitCredit { get; set; }
        public decimal MtlBurRate { get; set; }
        public decimal EstMtlBurUnitCost { get; set; }
        public bool Rfqneeded { get; set; }
        public int RfqvendQuotes { get; set; }
        public string AnalysisCode { get; set; }
        public string ReqdInPlant { get; set; }
        public string AltMethod { get; set; }
        public bool BaseMethodOverridden { get; set; }
        public string RelatedStage { get; set; }
        public string ParentAltMethod { get; set; }
        public int ParentMtlSeq { get; set; }
        public string Uomcode { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public string RuleTag { get; set; }
        public int ReqRefDes { get; set; }
        public bool PlanAsAsm { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ReassignSnasm { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
        public bool LocationView { get; set; }
    }
}
