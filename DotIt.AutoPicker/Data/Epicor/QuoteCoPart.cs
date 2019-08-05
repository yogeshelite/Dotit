using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteCoPart
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public string CoPartNum { get; set; }
        public string CoRevisionNum { get; set; }
        public int PartsPerOp { get; set; }
        public int LbrCostBase { get; set; }
        public int MtlCostBase { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public bool PreventSugg { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
