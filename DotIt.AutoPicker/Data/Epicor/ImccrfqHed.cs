using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImccrfqHed
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Seq { get; set; }
        public int CustNum { get; set; }
        public string Descr { get; set; }
        public string Comment { get; set; }
        public DateTime? DueDate { get; set; }
        public string ShipToNum { get; set; }
        public int ConNum { get; set; }
        public bool Synchronized { get; set; }
        public int QuoteNum { get; set; }
        public bool ReadyToSend { get; set; }
        public string AttachmentDir { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
