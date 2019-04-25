using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PrtaxCrd
    {
        public string Company { get; set; }
        public string TaxTblId { get; set; }
        public int TaxYear { get; set; }
        public string FileStatus { get; set; }
        public int TaxTblLine { get; set; }
        public decimal OverAmount { get; set; }
        public decimal NotOverAmount { get; set; }
        public decimal CreditPercent { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
