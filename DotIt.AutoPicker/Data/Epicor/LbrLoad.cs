using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LbrLoad
    {
        public string Company { get; set; }
        public bool ActiveTrans { get; set; }
        public string RecordIdentifier { get; set; }
        public string EmployeeNum { get; set; }
        public int LaborLoadSeq { get; set; }
        public int Shift { get; set; }
        public DateTime? ClockDate { get; set; }
        public DateTime? SysDate { get; set; }
        public int ClockTime { get; set; }
        public int SysTime { get; set; }
        public string LaborType { get; set; }
        public bool ReWork { get; set; }
        public string ReworkReasonCode { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public string ResourceGrpId { get; set; }
        public string OpCode { get; set; }
        public decimal LaborQty { get; set; }
        public decimal ScrapQty { get; set; }
        public string ScrapReasonCode { get; set; }
        public int SetupPctComplete { get; set; }
        public bool Complete { get; set; }
        public string IndirectCode { get; set; }
        public string LaborNote { get; set; }
        public string ResourceId { get; set; }
        public string ErrorMessage { get; set; }
        public bool NoClockOut { get; set; }
        public decimal DiscrepQty { get; set; }
        public string DiscrpRsnCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
