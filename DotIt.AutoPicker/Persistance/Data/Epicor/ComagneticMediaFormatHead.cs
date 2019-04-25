using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ComagneticMediaFormatHead
    {
        public ComagneticMediaFormatHead()
        {
            ComagneticMediaFormatDtl = new HashSet<ComagneticMediaFormatDtl>();
        }

        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string FormatId { get; set; }
        public int Version { get; set; }
        public decimal ReportLimit { get; set; }
        public decimal SmallAmountLimit { get; set; }
        public string SummaryColumn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ComagneticMediaDef ComagneticMediaDef { get; set; }
        public virtual ICollection<ComagneticMediaFormatDtl> ComagneticMediaFormatDtl { get; set; }
    }
}
