using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPacking
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public int ExtensionDigit { get; set; }
        public string PkgCode { get; set; }
        public decimal PkgHeight { get; set; }
        public decimal PkgLength { get; set; }
        public string PkgSizeUom { get; set; }
        public decimal PkgWidth { get; set; }
        public int PromptSetHeight { get; set; }
        public int PromptSetLength { get; set; }
        public decimal PromptSetWeight { get; set; }
        public int PromptSetWidth { get; set; }
        public bool Returnable { get; set; }
        public bool Serialized { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPkgCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPacking { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PkgTypeCode { get; set; }
        public int MaximumStack { get; set; }
        public decimal MaximumWeight { get; set; }
        public string VolumeUom { get; set; }
        public decimal InternalVolume { get; set; }
        public decimal ExternalVolume { get; set; }
        public bool Inactive { get; set; }
        public bool Expendable { get; set; }
        public decimal PkgInternalLength { get; set; }
        public decimal PkgInternalWidth { get; set; }
        public decimal PkgInternalHeight { get; set; }
        public int InternalPromptSetLength { get; set; }
        public int InternalPromptSetWidth { get; set; }
        public int InternalPromptSetHeight { get; set; }
        public string PkgMtlTypeCode { get; set; }
    }
}
