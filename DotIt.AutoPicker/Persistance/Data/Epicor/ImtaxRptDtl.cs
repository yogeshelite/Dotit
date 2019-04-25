using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxRptDtl
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
        public string BoxCode { get; set; }
        public decimal BoxAmount { get; set; }
        public decimal BoxSysAmount { get; set; }
        public bool Manual { get; set; }
        public bool Voided { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal DocBoxAmount { get; set; }
        public decimal DocBoxSysAmount { get; set; }
        public decimal Rpt1BoxAmount { get; set; }
        public decimal Rpt2BoxAmount { get; set; }
        public decimal Rpt3BoxAmount { get; set; }
        public decimal Rpt1BoxSysAmount { get; set; }
        public decimal Rpt2BoxSysAmount { get; set; }
        public decimal Rpt3BoxSysAmount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string MyindustryCode { get; set; }
        public string ChangeLog { get; set; }
    }
}
