using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImecsalesReport
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
