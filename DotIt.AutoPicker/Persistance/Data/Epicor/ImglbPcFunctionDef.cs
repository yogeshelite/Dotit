using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPcFunctionDef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FunctionName { get; set; }
        public string Description { get; set; }
        public string ConfigId { get; set; }
        public string FunctionType { get; set; }
        public string Expression { get; set; }
        public string ReturnType { get; set; }
        public string OldFunctionName { get; set; }
        public bool IsSync { get; set; }
        public bool GlobalFunc { get; set; }
        public string GlbCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ScriptExpression { get; set; }
    }
}
