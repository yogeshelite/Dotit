using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpoapvMsg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Ponum { get; set; }
        public string MsgType { get; set; }
        public DateTime? MsgDate { get; set; }
        public int MsgTime { get; set; }
        public string MsgTo { get; set; }
        public string MsgFrom { get; set; }
        public string MsgText { get; set; }
        public string ApproverResponse { get; set; }
        public string DcdUserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
