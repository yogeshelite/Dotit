using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Prw2dtlBox
    {
        public string Company { get; set; }
        public int TaxYear { get; set; }
        public int ControlNum { get; set; }
        public string BoxType { get; set; }
        public int BoxSeq { get; set; }
        public string BoxCode { get; set; }
        public decimal BoxAmount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
