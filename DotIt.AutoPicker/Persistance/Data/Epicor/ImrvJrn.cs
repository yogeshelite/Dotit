using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrvJrn
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int RvJrnUid { get; set; }
        public DateTime? JeDate { get; set; }
        public bool IsValid { get; set; }
        public string PostingMode { get; set; }
        public string SourceModule { get; set; }
        public string UserUid { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string Company { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? RvDate { get; set; }
        public bool Simulation { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
