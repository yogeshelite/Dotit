using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Plsaftcode
    {
        public string Company { get; set; }
        public string RateCode { get; set; }
        public string TaxCode { get; set; }
        public string Saftcode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
