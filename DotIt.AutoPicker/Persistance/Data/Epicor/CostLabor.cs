using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CostLabor
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string RateSourceTableName { get; set; }
        public string SourceId { get; set; }
        public string Description { get; set; }
        public decimal SetupLrate { get; set; }
        public decimal ProdLrate { get; set; }
        public bool Linked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
