using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbVendPbrk
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string OpCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int VendorNum { get; set; }
        public decimal BreakQty { get; set; }
        public decimal PriceModifier { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbOpCode { get; set; }
        public DateTime? GlbEffectiveDate { get; set; }
        public int GlbVendorNum { get; set; }
        public decimal GlbBreakQty { get; set; }
        public string PartCompany { get; set; }
        public string OldCompany { get; set; }
        public string OldPartNum { get; set; }
        public int OldVendorNum { get; set; }
        public string OldOpCode { get; set; }
        public DateTime? OldEffectiveDate { get; set; }
        public decimal OldBreakQty { get; set; }
        public decimal DaysOut { get; set; }
        public string Pum { get; set; }
        public int MfgNum { get; set; }
        public string MfgPartNum { get; set; }
        public string VendPartNum { get; set; }
        public string GlbPum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
