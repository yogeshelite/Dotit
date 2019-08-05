﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCcpackage
    {
        public string Company { get; set; }
        public string PackageCd { get; set; }
        public string PackageDesc { get; set; }
        public string ProgramCd { get; set; }
        public bool Inactive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}