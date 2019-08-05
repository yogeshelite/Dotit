using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImvendPbrk
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
        public string Pum { get; set; }
        public int VendorNum { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal BreakQty { get; set; }
        public decimal PriceModifier { get; set; }
        public decimal DaysOut { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
