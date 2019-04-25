using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class KanBanRcptSnformat
    {
        public string Company { get; set; }
        public string ReceiptId { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public string Snformat { get; set; }
        public string SnbaseDataType { get; set; }
        public string Snprefix { get; set; }
        public string Snmask { get; set; }
        public string SnmaskSuffix { get; set; }
        public string SnmaskPrefix { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
