﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Abtquery
    {
        public int AbtqueryUid { get; set; }
        public string Baqid { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public string Company { get; set; }
        public bool IsDefault { get; set; }
        public int AbtdocLineUid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
