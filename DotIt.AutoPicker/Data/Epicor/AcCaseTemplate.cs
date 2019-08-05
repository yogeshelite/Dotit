﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCaseTemplate
    {
        public string Company { get; set; }
        public string CaseCode { get; set; }
        public string IssueSummary { get; set; }
        public string CarePlanType { get; set; }
        public string WfgroupId { get; set; }
        public string TopicId1 { get; set; }
        public string TopicId2 { get; set; }
        public string TopicId3 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
