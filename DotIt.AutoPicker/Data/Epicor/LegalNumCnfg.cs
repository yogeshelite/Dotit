using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LegalNumCnfg
    {
        public string Company { get; set; }
        public string LegalNumberId { get; set; }
        public string Description { get; set; }
        public string LegalNumberType { get; set; }
        public string DefaultPrefix { get; set; }
        public string GenerationType { get; set; }
        public bool DispAfterGen { get; set; }
        public string PrefixType { get; set; }
        public bool PrefixIsOverrideable { get; set; }
        public string NumberOption { get; set; }
        public string Lncategory { get; set; }
        public bool AllowPrefixesByPlant { get; set; }
        public bool UsePreNumberFmt { get; set; }
        public bool AllowChangeAfterPrint { get; set; }
        public int NumLineDetails { get; set; }
        public bool ExcludeYrInNumber { get; set; }
        public string Separator { get; set; }
        public bool Inactive { get; set; }
        public string FiscalCalendarId { get; set; }
        public bool ExcludePerInNumber { get; set; }
        public int ExtensionDigit { get; set; }
        public bool GenSscc { get; set; }
        public int SeqLength { get; set; }
        public bool AllowPrefixesByWarehouse { get; set; }
        public bool AllowPrefixesByUser { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string GenerationOption { get; set; }
        public bool AutomaticVoiding { get; set; }
        public string AutomaticVoidingText { get; set; }
        public bool ChangeLog { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string Format { get; set; }
        public string ConditionalSeparator { get; set; }
        public string FreeText { get; set; }
        public string FiscalYearFormat { get; set; }
        public int FiscalPeriodLength { get; set; }
        public bool AddLeadingZero { get; set; }
    }
}
