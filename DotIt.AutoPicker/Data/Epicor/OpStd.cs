using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class OpStd
    {
        public string Company { get; set; }
        public string ResourceGrpId { get; set; }
        public string OpCode { get; set; }
        public string OpStdId { get; set; }
        public string Description { get; set; }
        public decimal SetupHours { get; set; }
        public decimal ProdStandard { get; set; }
        public string StdFormat { get; set; }
        public string StdBasis { get; set; }
        public decimal ApscontainerSize { get; set; }
        public string SetupGroup { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal QtyPerCycle { get; set; }
    }
}
