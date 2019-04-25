using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Boldetail
    {
        public string Company { get; set; }
        public int Bolnum { get; set; }
        public int Bolline { get; set; }
        public int Packages { get; set; }
        public string PkgCode { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public decimal Rate { get; set; }
        public string ClassRate { get; set; }
        public string PkgClass { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
