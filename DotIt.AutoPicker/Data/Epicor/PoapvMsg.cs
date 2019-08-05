using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PoapvMsg
    {
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
