using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EcsalesReport
    {
        public string Company { get; set; }
        public string EcsalesReportId { get; set; }
        public DateTime? EndDate { get; set; }
        public string RangeOption { get; set; }
        public bool RoundAmounts { get; set; }
        public DateTime? StartDate { get; set; }
        public string TaxList { get; set; }
        public string VattreportList { get; set; }
        public string Description { get; set; }
        public int EftheadUid { get; set; }
        public string OutputFile { get; set; }
        public bool ManualXml { get; set; }
        public string Module { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool InsideEuonly { get; set; }
        public string BereportType { get; set; }
        public string BerptLanguage { get; set; }
        public decimal BedspLimitAmount { get; set; }
    }
}
