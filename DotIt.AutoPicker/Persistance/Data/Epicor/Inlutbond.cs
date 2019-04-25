using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Inlutbond
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string BondLutnumber { get; set; }
        public DateTime BondYear { get; set; }
        public string BondLuttype { get; set; }
        public DateTime? BondLutdate { get; set; }
        public DateTime? BondLutexpiryDate { get; set; }
        public decimal BondLutvalue { get; set; }
        public bool Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
