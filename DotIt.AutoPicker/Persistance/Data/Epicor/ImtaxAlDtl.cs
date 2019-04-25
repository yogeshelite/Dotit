using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxAlDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
