using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MtlQueue
    {
        public string Company { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int MtlQueueSeq { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public decimal Quantity { get; set; }
        public string TranType { get; set; }
        public string ReferencePrefix { get; set; }
        public string Reference { get; set; }
        public string RequestedByEmpId { get; set; }
        public string SelectedByEmpId { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string JobSeqType { get; set; }
        public int JobSeq { get; set; }
        public string FromWhse { get; set; }
        public string FromBinNum { get; set; }
        public string ToWhse { get; set; }
        public string ToBinNum { get; set; }
        public int NextAssemblySeq { get; set; }
        public int NextJobSeq { get; set; }
        public DateTime? NeedByDate { get; set; }
        public int NeedByTime { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string TargetJobNum { get; set; }
        public int TargetAssemblySeq { get; set; }
        public int TargetMtlSeq { get; set; }
        public string RevisionNum { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public bool Visible { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public int Rmareceipt { get; set; }
        public int Rmadisp { get; set; }
        public int NctranId { get; set; }
        public string LotNum { get; set; }
        public bool Lock { get; set; }
        public string QueueId { get; set; }
        public int QueuePickSeq { get; set; }
        public int ReleaseForPickingSeq { get; set; }
        public string WhseGroupCode { get; set; }
        public string TranStatus { get; set; }
        public int WaveNum { get; set; }
        public int Priority { get; set; }
        public string TranSource { get; set; }
        public string LastMgrChangeEmpId { get; set; }
        public string AssignedToEmpId { get; set; }
        public string TargetTfordNum { get; set; }
        public int TargetTfordLine { get; set; }
        public string PackStation { get; set; }
        public string DistributionType { get; set; }
        public int Obs10PkgNum { get; set; }
        public int Obs10PkgLine { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
        public bool EpicorFsa { get; set; }
        public string LastUsedPcid { get; set; }
        public string FromPcid { get; set; }
        public string ToPcid { get; set; }
    }
}
