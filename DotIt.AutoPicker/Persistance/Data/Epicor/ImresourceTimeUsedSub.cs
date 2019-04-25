using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImresourceTimeUsedSub
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public bool WhatIf { get; set; }
        public int AllocNum { get; set; }
        public int ResourceNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public int StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public int EndTime { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string ResourceId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
