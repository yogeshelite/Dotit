using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PkgControl
    {
        public PkgControl()
        {
            PkgControlSegment = new HashSet<PkgControlSegment>();
        }

        public string Company { get; set; }
        public string Plant { get; set; }
        public string PkgControlType { get; set; }
        public string PkgControlIdcode { get; set; }
        public string PkgControlIddesc { get; set; }
        public string PkgCode { get; set; }
        public string ControlIdcode { get; set; }
        public bool AllowParentPcid { get; set; }
        public bool AllowMixedChildPcids { get; set; }
        public bool AllowMixedLots { get; set; }
        public bool AllowMixedUoms { get; set; }
        public bool AllowMultipleSerialNumsPerPcid { get; set; }
        public bool LabelPrintControlled { get; set; }
        public bool LabelPrintCounter { get; set; }
        public bool AllowVoid { get; set; }
        public bool AllowDelete { get; set; }
        public bool ArchivePcidhistory { get; set; }
        public bool Inactive { get; set; }
        public bool AllowMixedParts { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool InitializationHasOccurred { get; set; }
        public bool OutboundContainer { get; set; }
        public bool DefaultForStatic { get; set; }
        public bool DefaultForDynamic { get; set; }
        public string StaticEmptyWarehouseCode { get; set; }
        public string StaticEmptyBinNum { get; set; }

        public virtual ICollection<PkgControlSegment> PkgControlSegment { get; set; }
    }
}
