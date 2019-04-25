using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LabExpCd
    {
        public string Company { get; set; }
        public string ExpenseCode { get; set; }
        public string Description { get; set; }
        public bool GlpostCosts { get; set; }
        public int LaborRateSource { get; set; }
        public decimal LaborRate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
