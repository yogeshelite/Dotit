using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxCentD
    {
        public string Company { get; set; }
        public string CentCode { get; set; }
        public decimal CentFrom { get; set; }
        public decimal CentTo { get; set; }
        public decimal TaxAmount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
