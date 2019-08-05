using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxAlDtl
    {
        public string Company { get; set; }
        public string Algorithm { get; set; }
        public int LineNum { get; set; }
        public string Operand1 { get; set; }
        public string Operator { get; set; }
        public string Operand2 { get; set; }
        public string Operand3 { get; set; }
        public string Operand4 { get; set; }
        public bool BaseLine { get; set; }
        public bool TaxLine { get; set; }
        public string Operand3TaxCode { get; set; }
        public string Operand4TaxCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
