using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartSubs
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string SubPart { get; set; }
        public string RecType { get; set; }
        public string SubType { get; set; }
        public decimal QtyPer { get; set; }
        public string SalesUm { get; set; }
        public string Comment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
