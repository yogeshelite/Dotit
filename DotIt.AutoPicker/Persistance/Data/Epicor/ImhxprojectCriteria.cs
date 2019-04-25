using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImhxprojectCriteria
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int Revision { get; set; }
        public int AssemblySeq { get; set; }
        public decimal BurdenCost { get; set; }
        public string Company { get; set; }
        public DateTime? CriteriaDate { get; set; }
        public int CriteriaSeq { get; set; }
        public string CriteriaType { get; set; }
        public string JobNum { get; set; }
        public decimal LaborCost { get; set; }
        public decimal MaterialCost { get; set; }
        public string MilestoneId { get; set; }
        public decimal MtlBurdenCost { get; set; }
        public int OprSeq { get; set; }
        public string PhaseId { get; set; }
        public string ProjectId { get; set; }
        public decimal SubcontractCost { get; set; }
        public decimal TotalCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
