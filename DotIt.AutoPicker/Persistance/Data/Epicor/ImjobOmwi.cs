using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImjobOmwi
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int AllocNum { get; set; }
        public int ScheduleId { get; set; }
        public decimal ActualHours { get; set; }
        public DateTime? LoadDate { get; set; }
        public decimal LoadHour { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal StartHour { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal DueHour { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
