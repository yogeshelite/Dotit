using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacCslog
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal LogId { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogEventType { get; set; }
        public string LogDetail { get; set; }
        public string LogUser { get; set; }
        public string LogStatus { get; set; }
        public string LogErrorDesc { get; set; }
        public int CustNum { get; set; }
        public string CustId { get; set; }
        public decimal Raid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int LogTime { get; set; }
    }
}
