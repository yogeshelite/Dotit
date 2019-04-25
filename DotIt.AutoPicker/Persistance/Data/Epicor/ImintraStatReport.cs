using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImintraStatReport
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string Description { get; set; }
        public string DateSelection { get; set; }
        public int Year { get; set; }
        public int Period { get; set; }
        public string AccountSelection { get; set; }
        public string Flow { get; set; }
        public string BackDatedItems { get; set; }
        public bool RoundWeight { get; set; }
        public bool RoundAmount { get; set; }
        public bool Posted { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
