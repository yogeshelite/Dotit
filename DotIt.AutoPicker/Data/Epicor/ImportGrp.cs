﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImportGrp
    {
        public string Company { get; set; }
        public long ImportId { get; set; }
        public string ImportType { get; set; }
        public bool ErrorFlag { get; set; }
        public string Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
