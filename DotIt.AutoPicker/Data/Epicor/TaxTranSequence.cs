using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxTranSequence
    {
        public string Company { get; set; }
        public DateTime TranDate { get; set; }
        public int CurrentValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
