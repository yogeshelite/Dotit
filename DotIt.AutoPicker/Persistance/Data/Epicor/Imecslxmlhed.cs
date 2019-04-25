using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imecslxmlhed
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
        public string SysSubmission { get; set; }
        public string UsrSubmission { get; set; }
        public string SysTraderVrn { get; set; }
        public string UsrTraderVrn { get; set; }
        public int SysYear { get; set; }
        public int UsrYear { get; set; }
        public int SysPeriod { get; set; }
        public int UsrPeriod { get; set; }
        public string SysCurrencyA3 { get; set; }
        public string UsrCurrencyA3 { get; set; }
        public string SysContactName { get; set; }
        public string UsrContactName { get; set; }
        public int SysOnline { get; set; }
        public int UsrOnline { get; set; }
        public int SysBranch { get; set; }
        public int UsrBranch { get; set; }
        public string CreateUser { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int HedNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UsrPhone { get; set; }
        public string UsrEmailAddress { get; set; }
        public string ColumnSeparator { get; set; }
    }
}
