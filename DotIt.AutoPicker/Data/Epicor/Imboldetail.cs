using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imboldetail
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
