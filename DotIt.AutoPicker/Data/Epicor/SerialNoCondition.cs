using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SerialNoCondition
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string SerialNumber { get; set; }
        public int FsconditionId { get; set; }
        public DateTime? FsconditionDate { get; set; }
        public string FsassetConditionCode { get; set; }
        public string ResourceId { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public string FsadditionalDetails { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
