using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FsassetCondition
    {
        public string Company { get; set; }
        public string FsassetConditionCode { get; set; }
        public string FsassetConditionDesc { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
