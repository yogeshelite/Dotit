using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SolutionScriptStore
    {
        public string Company { get; set; }
        public string SolutionId { get; set; }
        public string ScriptName { get; set; }
        public string ScriptContent { get; set; }
        public int RunSequence { get; set; }
        public string ScriptStatus { get; set; }
        public int ExecuteTime { get; set; }
        public string Notes { get; set; }
        public string RunBy { get; set; }
        public DateTime? RunOn { get; set; }
        public string Results { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SolutionInstall SolutionInstall { get; set; }
    }
}
