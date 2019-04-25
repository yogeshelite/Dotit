using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class NacreditDoc
    {
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int Seq { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public decimal TotalAmt { get; set; }
        public string DocType { get; set; }
        public string DcdUserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
