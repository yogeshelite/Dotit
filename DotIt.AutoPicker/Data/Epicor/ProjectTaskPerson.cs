using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProjectTaskPerson
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string TaskId { get; set; }
        public string PersonId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ProjectTask ProjectTask { get; set; }
    }
}
