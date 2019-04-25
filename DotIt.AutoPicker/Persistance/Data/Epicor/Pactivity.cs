using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Pactivity
    {
        public string Company { get; set; }
        public string PaplanId { get; set; }
        public string Description { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? AppDate { get; set; }
        public decimal EstLaborHours { get; set; }
        public decimal EstBurdenHrs { get; set; }
        public decimal EstIndirectHrs { get; set; }
        public decimal EstReworkHrs { get; set; }
        public decimal ActLaborHrs { get; set; }
        public decimal ActBurdenHrs { get; set; }
        public decimal ActIndirectHrs { get; set; }
        public decimal ActReworkHrs { get; set; }
        public int ActId { get; set; }
        public string ActComments { get; set; }
        public DateTime? ActivityDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
