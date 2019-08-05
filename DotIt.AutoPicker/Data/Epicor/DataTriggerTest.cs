using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DataTriggerTest
    {
        public string CharField01 { get; set; }
        public string TextField01 { get; set; }
        public int IntField01 { get; set; }
        public bool LogicField01 { get; set; }
        public decimal DecimalField { get; set; }
        public DateTime? DateField01 { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
