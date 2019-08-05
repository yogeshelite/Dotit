using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CourseSchAttd
    {
        public string Company { get; set; }
        public string CourseId { get; set; }
        public string RevisionCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmpId { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal Expenses { get; set; }
        public bool CostReimbursed { get; set; }
        public string CourseResult { get; set; }
        public bool Passed { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
