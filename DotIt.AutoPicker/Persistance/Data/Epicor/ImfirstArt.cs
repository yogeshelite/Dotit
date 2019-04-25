using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfirstArt
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
        public string ResourceId { get; set; }
        public int SeqNum { get; set; }
        public decimal ExpectedQuantity { get; set; }
        public string InspectorId { get; set; }
        public string EmployeeNum { get; set; }
        public string EntryPerson { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public string Fastatus { get; set; }
        public DateTime? ActionDate { get; set; }
        public int ActionTime { get; set; }
        public string CommentText { get; set; }
        public decimal InspectedQuantity { get; set; }
        public string Plant { get; set; }
        public string Uomcode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
