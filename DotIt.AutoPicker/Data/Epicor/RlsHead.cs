using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RlsHead
    {
        public string Company { get; set; }
        public string RlsClassCode { get; set; }
        public int TopCustNum { get; set; }
        public int CustNum { get; set; }
        public int UnTieredGroup { get; set; }
        public int TierLevelNum { get; set; }
        public bool GlobalNa { get; set; }
        public bool IsCreditUpdated { get; set; }
        public decimal DocStartArtotal { get; set; }
        public decimal DocStartSototal { get; set; }
        public decimal DocStartPitotal { get; set; }
        public decimal StartArtotal { get; set; }
        public decimal StartSototal { get; set; }
        public decimal StartPitotal { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int Seq { get; set; }
        public string Lineage { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
