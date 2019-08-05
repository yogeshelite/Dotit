using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CostBurden
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string RateSourceTableName { get; set; }
        public string SourceId { get; set; }
        public string Description { get; set; }
        public string BurdenType { get; set; }
        public decimal ProdBurRate { get; set; }
        public decimal SetupBurRate { get; set; }
        public bool Linked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
