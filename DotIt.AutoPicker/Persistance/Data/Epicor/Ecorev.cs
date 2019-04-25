using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ecorev
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
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
        public string CheckInRevisionNum { get; set; }
        public DateTime? CheckInDate { get; set; }
        public bool CheckedOut { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public string CheckedOutBy { get; set; }
        public string SearchWord { get; set; }
        public string PartDescription { get; set; }
        public string PdmobjId { get; set; }
        public bool RevLocked { get; set; }
        public string RevLockedBy { get; set; }
        public string Plant { get; set; }
        public string ParentAltMethod { get; set; }
        public bool UseStaging { get; set; }
        public bool UseAltRevForParts { get; set; }
        public bool ValRefDes { get; set; }
        public string ConfigId { get; set; }
        public int GroupSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMes { get; set; }
        public string ProcessMode { get; set; }
        public string AltMethodDesc { get; set; }
    }
}
