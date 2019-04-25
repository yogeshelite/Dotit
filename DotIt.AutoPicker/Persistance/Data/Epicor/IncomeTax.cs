using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IncomeTax
    {
        public string Company { get; set; }
        public string IncomeTaxCode { get; set; }
        public string Description { get; set; }
        public string IncomeTaxType { get; set; }
        public bool Exempt { get; set; }
        public bool Deductible { get; set; }
        public bool Active { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
