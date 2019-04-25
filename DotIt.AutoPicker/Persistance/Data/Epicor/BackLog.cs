using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BackLog
    {
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public DateTime? ReqDate { get; set; }
        public string PartNum { get; set; }
        public string CustId { get; set; }
        public string Name { get; set; }
        public string TerritoryId { get; set; }
        public string CustGroup { get; set; }
        public string ProdGroup { get; set; }
        public decimal ReleaseValue { get; set; }
        public string LineDesc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
