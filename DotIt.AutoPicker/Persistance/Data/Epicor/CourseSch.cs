using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CourseSch
    {
        public string Company { get; set; }
        public string CourseId { get; set; }
        public string RevisionCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ActStartDate { get; set; }
        public DateTime? ActEndDate { get; set; }
        public string Location { get; set; }
        public int MaxAttendees { get; set; }
        public decimal CourseCost { get; set; }
        public string InstrType { get; set; }
        public string EmpId { get; set; }
        public int VendorNum { get; set; }
        public int CustNum { get; set; }
        public string Comments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
