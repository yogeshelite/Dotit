using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SchedParamImport
    {
        public string Company { get; set; }
        public long ImportId { get; set; }
        public int SchedParamSeq { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public DateTime? StartDate { get; set; }
        public int StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public int EndTime { get; set; }
        public bool WhatIf { get; set; }
        public bool Finite { get; set; }
        public string SchedTypeCode { get; set; }
        public bool OverrideMtlCon { get; set; }
        public int OverrideHistDateSetting { get; set; }
        public bool ScheduleDir { get; set; }
        public bool SuppressExceptions { get; set; }
        public int AllocNum { get; set; }
        public string ResourceId { get; set; }
        public bool IntError { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ErrorLog { get; set; }
    }
}
