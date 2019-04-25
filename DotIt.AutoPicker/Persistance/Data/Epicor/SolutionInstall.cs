using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SolutionInstall
    {
        public SolutionInstall()
        {
            SolutionScriptStore = new HashSet<SolutionScriptStore>();
        }

        public string Company { get; set; }
        public string SolutionId { get; set; }
        public byte[] Content { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int BuildIteration { get; set; }
        public string SolutionReference { get; set; }

        public virtual ICollection<SolutionScriptStore> SolutionScriptStore { get; set; }
    }
}
