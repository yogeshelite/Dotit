using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlobalSetting
    {
        public GlobalSetting()
        {
            GlobalSettingAttribute = new HashSet<GlobalSettingAttribute>();
        }

        public string SettingType { get; set; }
        public string Description { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual ICollection<GlobalSettingAttribute> GlobalSettingAttribute { get; set; }
    }
}
