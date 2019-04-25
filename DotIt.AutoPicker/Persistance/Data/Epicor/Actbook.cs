using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Actbook
    {
        public string Company { get; set; }
        public string BookId { get; set; }
        public string Description { get; set; }
        public string BookCurrency { get; set; }
        public string Booktype { get; set; }
        public string Coaid { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActiveFlag { get; set; }
        public bool DefaultBook { get; set; }
        public string MapBookId { get; set; }
        public int CoamapUid { get; set; }
        public bool UseMapFlag { get; set; }
        public int ActtypeUid { get; set; }
        public int Summarize { get; set; }
        public bool IsDefault { get; set; }
        public int MapType { get; set; }
        public int TranCurr { get; set; }
        public string Abtver { get; set; }
        public string PatchAbtver { get; set; }
        public int RulesetVer { get; set; }
        public int PatchRulesetVer { get; set; }
        public string Package { get; set; }
        public bool Modified { get; set; }
        public bool PrevModified { get; set; }
        public bool ManuallyUpdVer { get; set; }
        public bool UpdatePatchVer { get; set; }
        public string BasePackage { get; set; }
        public int LocRulesetVer { get; set; }
        public int LocPrevRulesetVer { get; set; }
        public int LocPatchRulesetVer { get; set; }
        public int LocPrevPatchRulesetVer { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool EnableCustomization { get; set; }
        public bool PartiallyUpdated { get; set; }
    }
}
