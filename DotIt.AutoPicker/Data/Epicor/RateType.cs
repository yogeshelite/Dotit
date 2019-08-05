﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RateType
    {
        public string Company { get; set; }
        public string RateTypeId { get; set; }
        public string Description { get; set; }
        public string DefaultMethod { get; set; }
        public string RateGrpCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
