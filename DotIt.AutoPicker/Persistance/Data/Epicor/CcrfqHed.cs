using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CcrfqHed
    {
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
