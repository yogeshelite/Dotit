using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class UserTracing
    {
        public UserTracing()
        {
            UserTracingFlag = new HashSet<UserTracingFlag>();
        }

        public string UserId { get; set; }
        public string AssemblyReflector { get; set; }
        public string BitFlagViewWatcher { get; set; }
        public string Catch { get; set; }
        public string CustomContext { get; set; }
        public bool DataTrace { get; set; }
        public bool DataTraceCcdataSet { get; set; }
        public bool DataTraceFullDataSets { get; set; }
        public bool DataTraceIncludeServerTrace { get; set; }
        public bool DataTraceReturnData { get; set; }
        public bool DataTraceDschanges { get; set; }
        public string DeploymentLogging { get; set; }
        public string DeregistrationException { get; set; }
        public string DialogException { get; set; }
        public string FormLoad { get; set; }
        public string LogException { get; set; }
        public string NotifyAll { get; set; }
        public string TransactionLoad { get; set; }
        public string DashboardException { get; set; }
        public string TraceHelp { get; set; }
        public string UitraceLogDirectory { get; set; }
        public string UitraceLocationScheme { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysUserFile User { get; set; }
        public virtual ICollection<UserTracingFlag> UserTracingFlag { get; set; }
    }
}
