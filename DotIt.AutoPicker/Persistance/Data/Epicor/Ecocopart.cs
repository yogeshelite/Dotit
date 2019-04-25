using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ecocopart
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string CoPartNum { get; set; }
        public string CoRevisionNum { get; set; }
        public int PartsPerOp { get; set; }
        public int LbrCostBase { get; set; }
        public int MtlCostBase { get; set; }
        public string PartDescription { get; set; }
        public string Ium { get; set; }
        public string AltMethod { get; set; }
        public bool PreventSugg { get; set; }
        public bool PrimaryCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
