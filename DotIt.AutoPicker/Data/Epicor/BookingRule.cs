using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BookingRule
    {
        public BookingRule()
        {
            BroperationCustom = new HashSet<BroperationCustom>();
        }

        public int RuleUid { get; set; }
        public int ActrevisionUid { get; set; }
        public string DisplayName { get; set; }
        public string DetailedDescription { get; set; }
        public string SelectionCriteria { get; set; }
        public string BookId { get; set; }
        public int ActtypeUid { get; set; }
        public bool IsPost { get; set; }
        public string ForEach { get; set; }
        public string Company { get; set; }
        public bool IsHeader { get; set; }
        public bool IsActive { get; set; }
        public string CreditContext { get; set; }
        public string DebitContext { get; set; }
        public string RefContext { get; set; }
        public string GlcontrolType { get; set; }
        public bool IsDefault { get; set; }
        public string Entity { get; set; }
        public bool IsReference { get; set; }
        public bool ManuallyUpdVer { get; set; }
        public int RuleVer { get; set; }
        public int PatchRuleVer { get; set; }
        public bool PrevModified { get; set; }
        public bool Modified { get; set; }
        public int LocVer { get; set; }
        public int LocPatchVer { get; set; }
        public bool LocModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool EnableCustomization { get; set; }

        public virtual ICollection<BroperationCustom> BroperationCustom { get; set; }
    }
}
