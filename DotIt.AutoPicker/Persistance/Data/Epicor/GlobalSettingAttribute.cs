using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlobalSettingAttribute
    {
        public string SettingType { get; set; }
        public string SettingAttribute { get; set; }
        public string SettingValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual GlobalSetting SettingTypeNavigation { get; set; }
    }
}
