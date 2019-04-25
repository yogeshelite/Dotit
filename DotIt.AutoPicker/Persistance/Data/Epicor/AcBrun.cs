using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcBrun
    {
        public string Company { get; set; }
        public decimal BrunId { get; set; }
        public string BcycleCd { get; set; }
        public decimal RecHeadId { get; set; }
        public decimal AdjGrpId { get; set; }
        public DateTime? ToDt { get; set; }
        public DateTime? InvDt { get; set; }
        public int CustNum { get; set; }
        public string BrunCreatedBy { get; set; }
        public string StatusVal { get; set; }
        public string BschHeadCd { get; set; }
        public bool AllBschHead { get; set; }
        public string SegCtcd { get; set; }
        public bool AllSegCt { get; set; }
        public string Rbtcd { get; set; }
        public bool AllRbt { get; set; }
        public string Seg1Cd { get; set; }
        public bool AllSeg1 { get; set; }
        public string Seg2Cd { get; set; }
        public bool AllSeg2 { get; set; }
        public string Seg3Cd { get; set; }
        public bool AllSeg3 { get; set; }
        public string Seg4Cd { get; set; }
        public bool AllSeg4 { get; set; }
        public bool ReadyToPost { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool AllArea { get; set; }
        public bool AllPackage { get; set; }
        public string AreaCd { get; set; }
        public string PackageCd { get; set; }
        public bool IsResidential { get; set; }
        public bool IsCommCare { get; set; }
    }
}
