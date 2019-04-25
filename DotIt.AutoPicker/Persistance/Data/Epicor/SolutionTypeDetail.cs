using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SolutionTypeDetail
    {
        public string SolutionTypeId { get; set; }
        public string SolutionTypeDetailId { get; set; }
        public string ElementHeaderId { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ElementHeader ElementHeader { get; set; }
        public virtual SolutionType SolutionType { get; set; }
    }
}
