using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SpecAttr
    {
        public string Company { get; set; }
        public string SpecType { get; set; }
        public string SpecId { get; set; }
        public string SpecRevNum { get; set; }
        public string AttributeId { get; set; }
        public string Description { get; set; }
        public string ScreenLabel { get; set; }
        public decimal MinDec { get; set; }
        public decimal MaxDec { get; set; }
        public decimal IncrPrec { get; set; }
        public DateTime? MinDate { get; set; }
        public DateTime? MaxDate { get; set; }
        public string InitVal { get; set; }
        public string ToolTip { get; set; }
        public string ListValues { get; set; }
        public bool GlobalSpecAttr { get; set; }
        public bool GlobalLock { get; set; }
        public string CmbPassValues { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
