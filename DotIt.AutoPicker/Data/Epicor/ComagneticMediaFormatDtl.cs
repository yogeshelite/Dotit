using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ComagneticMediaFormatDtl
    {
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string FormatId { get; set; }
        public int FormatLine { get; set; }
        public string ConceptId { get; set; }
        public string AccountIncluded { get; set; }
        public string AccountExcluded { get; set; }
        public string ReportColumn { get; set; }
        public bool SmallAmountLimit { get; set; }
        public int TypeOfMovement { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ComagneticMediaFormatHead ComagneticMediaFormatHead { get; set; }
    }
}
