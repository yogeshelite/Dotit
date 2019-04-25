using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrptParms
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string UserId { get; set; }
        public string ReportId { get; set; }
        public string SubReportId { get; set; }
        public int ParmSeq { get; set; }
        public DateTime? Pdate { get; set; }
        public string Pchar { get; set; }
        public int Pinteger { get; set; }
        public decimal Pdecimal { get; set; }
        public bool Plogical { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
