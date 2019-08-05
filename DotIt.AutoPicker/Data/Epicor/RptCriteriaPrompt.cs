using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptCriteriaPrompt
    {
        public string Company { get; set; }
        public string RptDefId { get; set; }
        public string RptCriteriaSetId { get; set; }
        public int PromptId { get; set; }
        public string PromptName { get; set; }
        public string DataType { get; set; }
        public string Label { get; set; }
        public string DefaultValue { get; set; }
        public string EpiGuid { get; set; }
        public bool IsConstant { get; set; }
        public string ConstantValue { get; set; }
        public bool IsVisible { get; set; }
        public int DisplayOrder { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptCriteriaSet Rpt { get; set; }
    }
}
