﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcFunctionDef
    {
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
