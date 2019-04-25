using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProjectCriteria
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string MilestoneId { get; set; }
        public int CriteriaSeq { get; set; }
        public string CriteriaType { get; set; }
        public DateTime? CriteriaDate { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal SubcontractCost { get; set; }
        public decimal LaborCost { get; set; }
        public decimal BurdenCost { get; set; }
        public decimal MtlBurdenCost { get; set; }
        public decimal TotalCost { get; set; }
        public string PhaseId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
