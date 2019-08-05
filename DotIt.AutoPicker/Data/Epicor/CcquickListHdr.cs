using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CcquickListHdr
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public int ConNum { get; set; }
        public string Name { get; set; }
        public string ShipToNum { get; set; }
        public string Description { get; set; }
        public DateTime? CrtDate { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
