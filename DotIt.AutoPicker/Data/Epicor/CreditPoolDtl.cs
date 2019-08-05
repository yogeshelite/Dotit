using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CreditPoolDtl
    {
        public string Company { get; set; }
        public string RlsClassCode { get; set; }
        public int TopCustNum { get; set; }
        public string CrdPoolCode { get; set; }
        public int ShareCustNum { get; set; }
        public decimal PrcShare { get; set; }
        public decimal CreditUsed { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
