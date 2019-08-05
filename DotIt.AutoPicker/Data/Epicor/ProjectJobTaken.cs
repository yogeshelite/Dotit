using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProjectJobTaken
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string JobNum { get; set; }
        public int Seq { get; set; }
        public decimal TakenLbr { get; set; }
        public decimal TakenBur { get; set; }
        public decimal TakenMtl { get; set; }
        public decimal TakenSub { get; set; }
        public decimal TakenMtlBur { get; set; }
        public decimal TakenOdc { get; set; }
        public DateTime? AppDate { get; set; }
        public bool IsManual { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PhaseId { get; set; }
    }
}
