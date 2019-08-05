using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AprvVend
    {
        public string Company { get; set; }
        public string Apvtype { get; set; }
        public int VendorNum { get; set; }
        public string PartNum { get; set; }
        public string ClassId { get; set; }
        public int CustNum { get; set; }
        public string OpCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
