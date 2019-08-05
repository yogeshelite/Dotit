﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobHwi
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int ScheduleId { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal StartHour { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal DueHour { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
