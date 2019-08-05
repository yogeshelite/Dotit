using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcourseRevision
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CourseId { get; set; }
        public string RevisionCode { get; set; }
        public string Description { get; set; }
        public DateTime? RevDate { get; set; }
        public DateTime? EffDate { get; set; }
        public int Duration { get; set; }
        public string DurationType { get; set; }
        public int ExpiresIn { get; set; }
        public string ExpirationType { get; set; }
        public string Syllabus { get; set; }
        public string Prerequisites { get; set; }
        public string Materials { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
