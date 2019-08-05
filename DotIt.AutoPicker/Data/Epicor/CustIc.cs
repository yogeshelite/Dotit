using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustIc
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string IctypeId { get; set; }
        public string Iccode { get; set; }
        public bool Primary { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
