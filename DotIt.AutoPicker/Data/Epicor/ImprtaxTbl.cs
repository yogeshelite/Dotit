using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImprtaxTbl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TaxTblId { get; set; }
        public int TaxYear { get; set; }
        public string FileStatus { get; set; }
        public int TaxTblLine { get; set; }
        public decimal OverAmount { get; set; }
        public decimal NotOverAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal OverTaxPct { get; set; }
        public decimal WkTaxId1 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
