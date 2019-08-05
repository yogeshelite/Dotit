using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PerBillDtl
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public int SummarizationDay { get; set; }
        public bool EndOfMonth { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TermsCode { get; set; }
    }
}
