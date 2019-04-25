using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcEquipPlan
    {
        public string Company { get; set; }
        public string EquipId { get; set; }
        public int PlanNum { get; set; }
        public string ProgramId { get; set; }
        public string PackageId { get; set; }
        public string ProjectId { get; set; }
        public string TaskSetId { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
