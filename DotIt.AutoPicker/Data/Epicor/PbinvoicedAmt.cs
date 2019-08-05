using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbinvoicedAmt
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string RelatedToFile { get; set; }
        public string TranKey { get; set; }
        public decimal DocPrepAmt { get; set; }
        public decimal PrepOverCeiling { get; set; }
        public decimal DocPrepOverCeiling { get; set; }
        public decimal GenOverCeiling { get; set; }
        public decimal DocGenOverCeiling { get; set; }
        public decimal PostOverCeiling { get; set; }
        public decimal DocPostOverCeiling { get; set; }
        public decimal GenAmt { get; set; }
        public decimal DocGenAmt { get; set; }
        public decimal PostAmt { get; set; }
        public decimal DocPostAmt { get; set; }
        public decimal PrepAmt { get; set; }
        public decimal CeilingLimit { get; set; }
        public decimal DocCeilingLimit { get; set; }
        public int InvoiceNum { get; set; }
        public string TaxCatId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
