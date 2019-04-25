using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImempCourse
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int EmpCourseId { get; set; }
        public string CourseId { get; set; }
        public string RevisionCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmpId { get; set; }
        public string CourseStatus { get; set; }
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
