using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CheckDigitUsage
    {
        public string CountryIsocode { get; set; }
        public string CheckDigitId { get; set; }
        public int UsageFeature { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
