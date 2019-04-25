using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxBoxTran
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public DateTime TranDate { get; set; }
        public int TranNum { get; set; }
        public string BoxCode { get; set; }
        public decimal BoxAmount { get; set; }
        public decimal DocBoxAmount { get; set; }
        public decimal Rpt1BoxAmount { get; set; }
        public decimal Rpt2BoxAmount { get; set; }
        public decimal Rpt3BoxAmount { get; set; }
        public string ReportId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
