using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MktgLstDtl
    {
        public string Company { get; set; }
        public string MktgListId { get; set; }
        public int SeqNum { get; set; }
        public string Type { get; set; }
        public int CustNum { get; set; }
        public string CustId { get; set; }
        public string ShipToNum { get; set; }
        public int ConNum { get; set; }
        public string BatchId { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
