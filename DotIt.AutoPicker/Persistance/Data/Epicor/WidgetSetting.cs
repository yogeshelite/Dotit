using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WidgetSetting
    {
        public string Company { get; set; }
        public string DcdUserId { get; set; }
        public string ProgramName { get; set; }
        public string FrameName { get; set; }
        public string WidgetType { get; set; }
        public string WidgetName { get; set; }
        public string AttrName { get; set; }
        public string AttrValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
