using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImextPrgrpEmpDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string EmpId { get; set; }
        public int DtlNum { get; set; }
        public DateTime? PayrollDate { get; set; }
        public string PayTypeId { get; set; }
        public decimal BaseHours { get; set; }
        public decimal Othours { get; set; }
        public decimal Hours3 { get; set; }
        public string Hours3Code { get; set; }
        public bool SentToFile { get; set; }
        public string TempDept { get; set; }
        public bool FromLabor { get; set; }
        public int Shift { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
