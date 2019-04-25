using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IntraStatReport
    {
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
