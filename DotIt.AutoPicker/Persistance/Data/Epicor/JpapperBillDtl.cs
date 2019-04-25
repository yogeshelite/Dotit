using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JpapperBillDtl
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public int SummarizationDay { get; set; }
        public bool EndOfMonth { get; set; }
        public string TermsCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual JpapperBillHead JpapperBillHead { get; set; }
    }
}
