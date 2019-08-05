﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRuleCode
    {
        public string Company { get; set; }
        public string RuleTypeCode { get; set; }
        public string RuleCode { get; set; }
        public string RuleDesc { get; set; }
        public string Program { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
