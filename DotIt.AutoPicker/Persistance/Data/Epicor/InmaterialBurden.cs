using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class InmaterialBurden
    {
        public string Company { get; set; }
        public string MaterialBurdenId { get; set; }
        public string TaxLiability { get; set; }
        public string Ptc { get; set; }
        public decimal BurdenPercentage { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
