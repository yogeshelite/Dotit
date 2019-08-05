using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImextPremp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string EmpId { get; set; }
        public string ExtIntEmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string EmpName { get; set; }
        public string SocSecNum { get; set; }
        public bool Inactive { get; set; }
        public string PayClassId { get; set; }
        public string PayMethod { get; set; }
        public string Frequency { get; set; }
        public string EmpClass { get; set; }
        public DateTime? HireDate { get; set; }
        public bool Terminated { get; set; }
        public DateTime? TerminatedDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
