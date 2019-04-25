using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbProdGrupPlt
    {
        public string Company { get; set; }
        public string JobClosingCode { get; set; }
        public string JobCompletionCode { get; set; }
        public string OwnerPlant { get; set; }
        public string Planner { get; set; }
        public string ProdCode { get; set; }
        public string SupplyPlant { get; set; }
        public string GlbCompany { get; set; }
        public string GlbProdCode { get; set; }
        public string GlbOwnerPlant { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalProdGrupPlt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
