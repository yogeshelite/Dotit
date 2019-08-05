using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartRevInspVend
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public string VendorId { get; set; }
        public string Plant { get; set; }
        public bool SkipLotCtl { get; set; }
        public string SkipLotCtlCode { get; set; }
        public int InspCnt { get; set; }
        public int SkipCnt { get; set; }
        public int RptCycles { get; set; }
        public int RejectCnt { get; set; }
        public string RejectCntBy { get; set; }
        public int SampleSize { get; set; }
        public decimal SampleSizePct { get; set; }
        public bool ForceInsp { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
