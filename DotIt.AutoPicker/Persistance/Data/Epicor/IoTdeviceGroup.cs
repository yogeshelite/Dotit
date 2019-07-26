﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IoTdeviceGroup
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
