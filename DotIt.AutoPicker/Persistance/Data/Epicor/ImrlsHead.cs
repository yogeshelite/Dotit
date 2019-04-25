using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrlsHead
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
