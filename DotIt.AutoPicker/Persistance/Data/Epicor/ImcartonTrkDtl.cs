using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcartonTrkDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ShipmentType { get; set; }
        public int PackNum { get; set; }
        public int CaseNum { get; set; }
        public decimal PkgLength { get; set; }
        public decimal PkgHeight { get; set; }
        public decimal PkgWidth { get; set; }
        public string TrackingNumber { get; set; }
        public decimal PkgWeight { get; set; }
        public bool Codflag { get; set; }
        public bool Codcheck { get; set; }
        public decimal Codamount { get; set; }
        public bool DeclaredValueFlag { get; set; }
        public decimal DeclaredValue { get; set; }
        public string ManifestSizeUom { get; set; }
        public string ManifestWtUom { get; set; }
        public decimal ManifestWeight { get; set; }
        public decimal ManifestLength { get; set; }
        public decimal ManifestWidth { get; set; }
        public decimal ManifestHeight { get; set; }
        public decimal Codvalue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
