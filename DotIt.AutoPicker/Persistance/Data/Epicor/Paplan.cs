using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Paplan
    {
        public string Company { get; set; }
        public string PaplanId { get; set; }
        public string Description { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public decimal EstLaborHours { get; set; }
        public decimal EstBurdenHrs { get; set; }
        public decimal EstIndirectHrs { get; set; }
        public decimal EstReworkHrs { get; set; }
        public string PaweekId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
