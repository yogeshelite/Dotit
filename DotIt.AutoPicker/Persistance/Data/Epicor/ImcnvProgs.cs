using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcnvProgs
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SystemCode { get; set; }
        public string ConversionId { get; set; }
        public int RunSequence { get; set; }
        public string Program { get; set; }
        public string RunLevel { get; set; }
        public string LastRunLevel { get; set; }
        public string Description { get; set; }
        public bool AutoRun { get; set; }
        public bool InitialRun { get; set; }
        public bool UserRun { get; set; }
        public bool ReCoverable { get; set; }
        public bool ReRunable { get; set; }
        public bool RunInDisconnectedCrm { get; set; }
        public string ProgStatus { get; set; }
        public DateTime? LastRunOn { get; set; }
        public string RunUserId { get; set; }
        public string RunLog { get; set; }
        public string ProcessId { get; set; }
        public long? RunTaskNum { get; set; }
        public string ConversionSetting { get; set; }
        public string SettingFilename { get; set; }
        public DateTime? SettingLastUpdated { get; set; }
        public string SettingLastUpdatedBy { get; set; }
        public int ProgressPercent { get; set; }
        public string UserPromptProgram { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ConversionType { get; set; }
        public string RunFrequency { get; set; }
        public string ObsoleteRunLevel { get; set; }
        public DateTime? InternalRunDate { get; set; }
    }
}
