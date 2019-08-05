using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProjCost
    {
        public string ProjectId { get; set; }
        public string ClassId { get; set; }
        public string ClassDescription { get; set; }
        public decimal EstMtlCost { get; set; }
        public decimal EstSubCost { get; set; }
        public decimal ActMtlCost { get; set; }
        public decimal ActSubCost { get; set; }
        public decimal QuotedMtlCost { get; set; }
        public decimal QuotedSubCost { get; set; }
        public decimal EstMtlBurCost { get; set; }
        public decimal ActMtlBurCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
