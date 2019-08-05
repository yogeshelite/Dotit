using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class UserSetting
    {
        public string Company { get; set; }
        public string Procedure { get; set; }
        public string Type { get; set; }
        public string DcdUserId { get; set; }
        public string WidgetName { get; set; }
        public string SettingId { get; set; }
        public string SettingValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
